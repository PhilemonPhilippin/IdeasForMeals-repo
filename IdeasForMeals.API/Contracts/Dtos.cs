namespace IdeasForMeals.API.Contracts;

public record FoodGroupDto(Guid Id, string Name);
public record FoodDto(Guid Id,string Name, FoodGroupDto FoodGroup);
public record IdeaForMealDto(string Carbohydrate, string Protein, string Vegetable, string Fruit);
public record RecipeDto(string Content);
