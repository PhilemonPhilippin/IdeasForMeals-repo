using IdeasForMeals.Core.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Services;

public interface IIdeaForMealService
{
    Task<List<Food>> GetIdeaForMeal(string idAuth0);
    Task<string> GetRecipe(List<string> ingredients);
    string GetPdf(string recipe);
}
