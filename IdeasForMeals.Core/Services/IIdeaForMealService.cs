using IdeasForMeals.Core.Database.Entities;

namespace IdeasForMeals.Core.Services;

public interface IIdeaForMealService
{
    Task<List<Food>> GetIdeaForMeal(string idAuth0);
    Task<string> GetRecipe(List<string> ingredients);
    string GetPdf(string recipe);
}
