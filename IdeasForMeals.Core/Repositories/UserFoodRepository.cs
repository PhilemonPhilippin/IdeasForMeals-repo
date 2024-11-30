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

    public IQueryable<UserFood> ReadAll(string idAuth0)
    {
        User user = _dbContext.Users.First(u => u.IdAuth0 == idAuth0);
        Guid userId = user.Id;

        // Get the user food relations for foods which are at the moment in the diet of a specific user.
        // Food and its FoodGroup included.
        IQueryable<UserFood> userFoods = _dbContext.UserFoods.Where(uf => uf.UserId == userId && uf.IsCurrentDiet).Include(uf => uf.Food).ThenInclude(f => f.FoodGroup);

        return userFoods;
    }

    public async Task<bool> UpdateOutOfDiet(List<Guid> foodIds, string idAuth0)
    {
        User user = await _dbContext.Users.FirstAsync(u => u.IdAuth0 == idAuth0);
        Guid userId = user.Id;

        IQueryable<UserFood> userFoods = _dbContext.UserFoods.Where(uf => uf.UserId == userId && foodIds.Contains(uf.FoodId));

        if (userFoods.Any() == false) return false;

        foreach (var userFood in userFoods)
        {
            userFood.IsCurrentDiet = false;
            userFood.ModifiedAt = DateTime.UtcNow;
        }

        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task CreateIntoDiet(string name, Guid foodGroupId, string idAuth0)
    {
        User user = await _dbContext.Users.FirstAsync(u => u.IdAuth0 == idAuth0);
        Guid userId = user.Id;

        Food? existingFood = await _dbContext.Foods.Where(f => f.Name.ToLower() == name.ToLower()).FirstOrDefaultAsync();
        if (existingFood is not null)
        {
            UserFood? existingUserFood = await _dbContext.UserFoods.FindAsync(userId, existingFood.Id);
            if (existingUserFood is not null)
            {
                existingUserFood.IsCurrentDiet = true;
                existingUserFood.ModifiedAt = DateTime.UtcNow;
            }
            else
            {
                UserFood newUserFood = new()
                {
                    UserId = userId,
                    FoodId = existingFood.Id
                };
                await _dbContext.AddAsync(newUserFood);
            }
        }
        else
        {
            Food newFood = new()
            {
                Name = name.ToLower(),
                FoodGroupId = foodGroupId,
                CreatedBy = userId,
            };
            UserFood newUserFood = new()
            {
                UserId = userId,
                FoodId = newFood.Id
            };
            await _dbContext.AddAsync(newFood);
            await _dbContext.AddAsync(newUserFood);
        }
        await _dbContext.SaveChangesAsync();

    }
}
