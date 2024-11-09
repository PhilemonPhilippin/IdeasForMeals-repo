using IdeasForMeals.Core.Database;
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

    public async Task<List<Food>> ReadAll()
    {
        return await _dbContext.Foods.Include(f => f.FoodGroup).OrderBy(f => f.Name).ToListAsync();
    }
}
