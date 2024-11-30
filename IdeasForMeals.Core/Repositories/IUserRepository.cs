using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Repositories;

public interface IUserRepository
{
    Task<bool> CheckUser(string idAuth0);
}
