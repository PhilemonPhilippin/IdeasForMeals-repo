﻿using IdeasForMeals.Core.Database;
using IdeasForMeals.Core.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Repositories;

public class FoodRepository(AppDbContext dbContext) : IFoodRepository
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task<List<Food>> ReadAllInitialSeed()
    {
        return await _dbContext.Foods.Where(f => f.FromInitialSeed).Include(f => f.FoodGroup).OrderBy(f => f.Name).ToListAsync();
    }

    public async Task<List<Food>> GetDiet(string idAuth0)
    {
        User user = await _dbContext.Users.FirstAsync(u => u.IdAuth0 == idAuth0);
        Guid userId = user.Id;

        var foods = _dbContext.UserFoods.Where(uf => uf.UserId == userId && uf.IsCurrentDiet).Include(uf => uf.Food).ThenInclude(f => f.FoodGroup).Select(uf => uf.Food).OrderBy(f => f.Name);

        return await foods.ToListAsync();
    }
}
