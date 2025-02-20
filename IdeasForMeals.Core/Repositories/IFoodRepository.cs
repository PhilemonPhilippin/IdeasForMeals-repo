using IdeasForMeals.Core.Database.Entities;

namespace IdeasForMeals.Core.Repositories;

public interface IFoodRepository
{
    Task<List<Food>> GetDiet(string idAuth0);
}
