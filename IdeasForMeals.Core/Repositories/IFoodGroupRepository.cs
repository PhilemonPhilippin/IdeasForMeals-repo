using IdeasForMeals.Core.Database.Entities;

namespace IdeasForMeals.Core.Repositories;

public interface IFoodGroupRepository
{
    public Task<List<FoodGroup>> ReadAll();
}
