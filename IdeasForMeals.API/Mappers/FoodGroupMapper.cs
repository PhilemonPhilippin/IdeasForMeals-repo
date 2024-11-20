using IdeasForMeals.API.Contracts;
using IdeasForMeals.Core.Database.Entities;

namespace IdeasForMeals.API.Mappers;

public static class FoodGroupMapper
{
    public static FoodGroupDto MapToDto(this FoodGroup group) => new(group.Id, group.Name);
}
