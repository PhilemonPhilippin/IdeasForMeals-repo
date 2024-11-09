namespace IdeasForMeals.API.Contracts;

public record FoodGroupDto(Guid Id, string Name, string? Description);
public record FoodDto(Guid Id,string Name, string? Description, FoodGroupDto FoodGroup);
