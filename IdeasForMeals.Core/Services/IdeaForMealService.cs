using IdeasForMeals.Core.Database;
using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.AI;
using OllamaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        string prompt = $"I am giving you three ingredients. One is from the carbohydrate food group, one from the protein food group and one from the vegetable : {ingredients[0]}, {ingredients[1]} and {ingredients[2]}. I want you to explain to me, as if it was a detailed cooking recipe, what are the different steps to prepare these ingredients. I want to know if I need to wash them, or peel them, or cook them, and I want to know how I can do this. The answer must not be longer than 1500 words, but it can be shorter. You must structure your answer in three parts, one for each ingredient, and it must be plain text.";

        var context = ollama.CompleteStreamingAsync(prompt);

        StringBuilder myString = new();

        await foreach (var item in context)
        {
            myString.Append(item.Text);
        }

        return myString.ToString();
    }
}
