using IdeasForMeals.Core.Database.Entities;

namespace IdeasForMeals.Core.Repositories;

public interface IUserFoodRepository
{
    IQueryable<UserFood> ReadAll(string idAuth0);
    Task<bool> UpdateOutOfDiet(List<Guid> foodIds, string idAuth0);
    Task CreateIntoDiet(string name, Guid foodGroupId, string idAuth0);
}
