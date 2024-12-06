using IdeasForMeals.Core.Database;
using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.AI;
using OllamaSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Quality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        string prompt = $"I am giving you three ingredients. One is from the carbohydrate food group, one from the protein food group and one from the vegetable : {ingredients[0]}, {ingredients[1]} and {ingredients[2]}. I want you to explain to me, as if it was a detailed cooking recipe, what are the different steps to prepare these ingredients. I want to know if I need to wash them, or peel them, or cook them, and I want to know how I can do this. The answer must not be longer than 5100 characters, but it can be shorter. You must structure your answer in three parts, one for each ingredient, and it must be plain text.";

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

        // Get an XGraphics object for drawing on this page.
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
                // If we arrived at the last sentence.
                if (totalChars == recipe.Length)
                {
                    string finalLineToWrite = lineToWrite.ToString();
                    gfx.DrawString(finalLineToWrite, font, XBrushes.Black, new XRect(5, yCount, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    lineCount++;
                }
                else
                {
                    // Stop at the previous word, draw the line.
                    // And then keep the letters after the line in order to make the following line.
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

        // Save the document...
        var filename = PdfFileUtility.GetTempPdfFullFileName("samples/RecipeIdea");
        document.Save(filename);

        // ...and start a viewer.
        PdfFileUtility.ShowDocument(filename);

        return filename;
    }
}
