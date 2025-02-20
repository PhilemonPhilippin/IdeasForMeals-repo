using IdeasForMeals.Core.Database;
using IdeasForMeals.Core.Database.Entities;

namespace IdeasForMeals.Core.Repositories;

public class UserRepository(AppDbContext dbContext) : IUserRepository
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task EnsureUserCreated(string idAuth0)
    {
        bool userExist = _dbContext.Users.Any(u => u.IdAuth0 == idAuth0);

        if (userExist)
        {
            return;
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
    }
}
