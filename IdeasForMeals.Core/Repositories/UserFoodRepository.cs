using IdeasForMeals.Core.Database;
using IdeasForMeals.Core.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Repositories;

public class UserFoodRepository(AppDbContext dbContext) : IUserFoodRepository
{
    private readonly AppDbContext _dbContext = dbContext;

    public IQueryable<UserFood> ReadAll()
    {
        // At the moment, there is only one user in the database, the "admin"
        Guid admin = _dbContext.Users.First().Id;

        // Get the user food relations for foods which are at the moment in the diet of a specific user.
        // Food and its FoodGroup included.
        IQueryable<UserFood> userFoods = _dbContext.UserFoods.Where(uf => uf.UserId == admin && uf.IsCurrentDiet).Include(uf => uf.Food).ThenInclude(f => f.FoodGroup);

        return userFoods;
    }

    public async Task<bool> UpdateOutOfDiet(List<Guid> foodIds)
    {
        // At the moment, there is only one user in the database, the "admin"
        Guid admin = _dbContext.Users.First().Id;

        IQueryable<UserFood> userFoods = _dbContext.UserFoods.Where(uf => uf.UserId == admin && foodIds.Contains(uf.FoodId));

        if (userFoods.Any() == false) return false;

        foreach (var userFood in userFoods)
        {
            userFood.IsCurrentDiet = false;
            userFood.ModifiedAt = DateTime.UtcNow;
        }

        await _dbContext.SaveChangesAsync();

        return true;
    }
}
