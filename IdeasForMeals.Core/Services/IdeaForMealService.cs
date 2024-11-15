﻿using IdeasForMeals.Core.Database;
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

    public async Task<List<Food>> GetIdeaForMeal()
    {
        Random random = new();
        List<Food> retval = [];

        // Selecting only the Food included in the UserFood
        IQueryable<Food> source = _userFoodRepository.ReadAll().Select(uf => uf.Food);

        // Group by each FoodGroup
        var proteinSource = source.Where(f => f.FoodGroup.Name == "protein");
        var carbohydrateSource = source.Where(f => f.FoodGroup.Name == "carbohydrate");
        var vegetableSource = source.Where(f => f.FoodGroup.Name == "vegetable");
        var fruitSource = source.Where(f => f.FoodGroup.Name == "fruit");

        // Adding into the list by (important) order : carb, prot, veggie then fruit)
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