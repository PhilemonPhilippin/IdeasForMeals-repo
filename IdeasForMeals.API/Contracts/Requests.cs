using System.ComponentModel.DataAnnotations;

namespace IdeasForMeals.API.Contracts;

public record FoodRequest([Required][MaxLength(100)] string Name,[Required] Guid FoodGroupId);