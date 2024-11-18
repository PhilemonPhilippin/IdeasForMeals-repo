using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Database.Entities;

public class UserFood : DateMetadata
{
    public Guid UserId { get; set; }
    public User User { get; set; }

    public Guid FoodId { get; set; }
    public Food Food { get; set; }

    public bool IsCurrentDiet { get; set; }

    public UserFood()
    {
        IsCurrentDiet = true;
    }
}
