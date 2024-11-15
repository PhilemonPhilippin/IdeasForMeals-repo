using IdeasForMeals.Core.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Services;

public interface IIdeaForMealService
{
    public Task<List<Food>> GetIdeaForMeal();
}
