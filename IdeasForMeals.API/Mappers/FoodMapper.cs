using IdeasForMeals.API.Contracts;
using IdeasForMeals.Core.Database.Entities;

namespace IdeasForMeals.API.Mappers;

public static class FoodMapper
{
    public static FoodDto MapToDto(this Food food) => new(food.Id, food.Name, food.Description, 
        new FoodGroupDto(food.FoodGroup.Id, food.FoodGroup.Name, food.FoodGroup.Description));

}
