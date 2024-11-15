using IdeasForMeals.API.Contracts;
using IdeasForMeals.Core.Database.Entities;

namespace IdeasForMeals.API.Mappers;

public static class IdeaForMealMapper
{
    public static IdeaForMealDto MapToDto(List<Food> foods)
    {
        // Order is carb, prot, veggie then fruit.
        return new IdeaForMealDto(foods[0].Name, foods[1].Name, foods[2].Name, foods[3].Name);
    }
}
