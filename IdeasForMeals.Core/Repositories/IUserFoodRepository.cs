using IdeasForMeals.Core.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Repositories;

public interface IUserFoodRepository
{
    IQueryable<UserFood> ReadAll(string idAuth0);
    Task<bool> UpdateOutOfDiet(List<Guid> foodIds, string idAuth0);
    Task CreateIntoDiet(string name, Guid foodGroupId, string idAuth0);
}
