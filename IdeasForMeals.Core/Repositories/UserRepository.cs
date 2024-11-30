using IdeasForMeals.Core.Database;
using IdeasForMeals.Core.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Repositories;

public class UserRepository(AppDbContext dbContext) : IUserRepository
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task<bool> CheckUser(string idAuth0)
    {
        bool userExist = _dbContext.Users.Any(u => u.IdAuth0 == idAuth0);

        if (userExist)
        {
            return true;
        }

        User newUser = new() { IdAuth0 = idAuth0 };
        await _dbContext.Users.AddAsync(newUser);

        IQueryable<Guid> foods = _dbContext.Foods.Where(f => f.FromInitialSeed).Select(f => f.Id);

        List<UserFood> userFoods = new();
        foreach (Guid food in foods)
        {
            userFoods.Add(new UserFood() { UserId = newUser.Id, FoodId = food });
        }
        await _dbContext.AddRangeAsync(userFoods);

        await _dbContext.SaveChangesAsync();
        return false;
    }
}
