﻿using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.AI;
using OllamaSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Quality;
using System.Text;

namespace IdeasForMeals.Core.Services;

public class IdeaForMealService(IUserFoodRepository userFoodRepository) : IIdeaForMealService
{
    private readonly IUserFoodRepository _userFoodRepository = userFoodRepository;

    public async Task<List<Food>> GetIdeaForMeal(string idAuth0)
    {
        Random random = new();
        List<Food> retval = [];

        // Selecting only the Food included in the UserFoods
        IQueryable<Food> source = _userFoodRepository.ReadAll(idAuth0).Select(uf => uf.Food);

        // Group by each FoodGroup
        var carbohydrateSource = source.Where(f => f.FoodGroup.Name == "carbohydrate");
        var proteinSource = source.Where(f => f.FoodGroup.Name == "protein");
        var vegetableSource = source.Where(f => f.FoodGroup.Name == "vegetable");
        var fruitSource = source.Where(f => f.FoodGroup.Name == "fruit");

        // Adding to the list by (important) order : carb, prot, veggie then fruit)
        Food carbohydrate = await GetRandomFood(carbohydrateSource, random);
        retval.Add(carbohydrate);

        Food protein = await GetRandomFood(proteinSource, random);
        retval.Add(protein);

        Food vegetable = await GetRandomFood(vegetableSource, random);
        retval.Add(vegetable);

        Food fruit = await GetRandomFood(fruitSource, random);
        retval.Add(fruit);

        return retval;
    }

    private async Task<Food> GetRandomFood(IQueryable<Food> foods, Random random)
    {
        int total = await foods.CountAsync();
        int offset = random.Next(0, total);

        Food food = await foods.Skip(offset).FirstAsync();
        return food;
    }

    public async Task<string> GetRecipe(List<string> ingredients)
    {
        Uri uri = new("http://localhost:11434");
        OllamaApiClient ollama = new(uri);
        ollama.SelectedModel = "llama3.2";

        string prompt = $"I am giving you three ingredients. One is from the carbohydrate food group, one from the protein food group and one from the vegetable : {ingredients[0]}, {ingredients[1]} and {ingredients[2]}. I want you to explain to me, like for a cooking recipe, what are the different steps to prepare these ingredients. I want to know if I need to wash it, or if I need to peel it and how to peel it, and I also want to know how to cook it (with what utensils, how long do I need to cook it, do I need to add fat, etc.). The answer must not be longer than 5100 characters, but it can be shorter. You must structure your answer in three parts, one for each ingredient, and it must be plain text.";

        var context = ollama.CompleteStreamingAsync(prompt);

        StringBuilder myString = new();

        await foreach (var item in context)
        {
            myString.Append(item.Text);
        }

        return myString.ToString();
    }

    public string GetPdf(string recipe)
    {
        var document = new PdfDocument();
        document.Info.Title = "Recipe";
        document.Info.Subject = "A recipe describing how to prepare the ingredients.";

        var page = document.AddPage();

        var gfx = XGraphics.FromPdfPage(page);

        var font = new XFont("Verdana", 10, XFontStyleEx.Regular);

        const int maxCharsOnALine = 106;
        const int lineHeight = 16;
        int lineCount = 0;
        int charCount = 0;
        int totalChars = 0;
        StringBuilder lineToWrite = new();
        int yCount = 16;

        foreach (char c in recipe)
        {
            charCount++;
            totalChars++;
            lineToWrite.Append(c);

            if (charCount == maxCharsOnALine || totalChars == recipe.Length)
            {
                // If we arrived at the last sentence, just write the final line.
                if (totalChars == recipe.Length)
                {
                    string finalLineToWrite = lineToWrite.ToString();
                    gfx.DrawString(finalLineToWrite, font, XBrushes.Black, new XRect(5, yCount, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    lineCount++;
                }
                else
                {
                    // While we process trough the text and we arrive at the maxCharsOnALine number of characters, stop there and draw the line.
                    // Meaning : stop at the previous word before the end of line (so that it does not break a word in two) and draw the line.
                    // And then save the letters after the drawed line to start the next line.
                    string lineToWriteString = lineToWrite.ToString();
                    int indexOfLastSpace = lineToWriteString.LastIndexOf(" ");
                    string charactersAfterSpace = lineToWriteString.Substring(indexOfLastSpace);
                    int numberOfCharactersAfterSpace = charactersAfterSpace.Length;
                    string definitiveLineToWrite = lineToWriteString.Substring(0, lineToWrite.Length - numberOfCharactersAfterSpace);

                    gfx.DrawString(definitiveLineToWrite, font, XBrushes.Black, new XRect(5, yCount, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    yCount += lineHeight;
                    lineCount++;
                    lineToWrite.Clear();
                    lineToWrite.Append(charactersAfterSpace);
                    charCount = numberOfCharactersAfterSpace;
                }
            }
        }

        string filename = PdfFileUtility.GetTempPdfFullFileName("samples/RecipeIdea");
        document.Save(filename);
        return filename;
    }
}
