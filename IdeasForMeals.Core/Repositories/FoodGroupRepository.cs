using IdeasForMeals.Core.Database;
using IdeasForMeals.Core.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdeasForMeals.Core.Repositories;

public class FoodGroupRepository(AppDbContext dbContext) : IFoodGroupRepository
{
    private readonly AppDbContext _dbContext = dbContext;
    public async Task<List<FoodGroup>> ReadAll()
    {
        List<FoodGroup> groups = await _dbContext.FoodGroups.OrderBy(g => g.Name).ToListAsync();
        return groups;
    }
}
