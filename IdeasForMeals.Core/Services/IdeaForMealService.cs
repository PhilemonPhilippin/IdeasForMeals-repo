using IdeasForMeals.Core.Database;
using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Repositories;
using Microsoft.EntityFrameworkCore;
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
}
