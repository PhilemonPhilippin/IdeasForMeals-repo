using IdeasForMeals.Core.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Database;

public class SeedGenerator
{
    public User Admin { get; init; }
    public List<FoodGroup> FoodGroups { get; init; }
    public List<Food> Foods { get; init; }
    public List<UserFood> UserFoods { get; init; }

    public SeedGenerator()
    {
        Admin = new User { Alias = "Admin#0000" };
        FoodGroups = CreateFoodGroups();
        Foods = CreateFoods();
        UserFoods = CreateUserFoods();
    }

    public List<FoodGroup> CreateFoodGroups()
    {
        return [
            new FoodGroup {
            Name = "carbohydrate"
        },
            new FoodGroup {
            Name = "protein"
        },
            new FoodGroup {
            Name = "vegetable"
        },
            new FoodGroup {
            Name = "fruit"
        }
            ];
    }

    public List<Food> CreateFoods()
    {
        Guid carbohydrate = FoodGroups.First(fg => fg.Name == "carbohydrate").Id;
        Guid protein = FoodGroups.First(fg => fg.Name == "protein").Id;
        Guid vegetable = FoodGroups.First(fg => fg.Name == "vegetable").Id;
        Guid fruit = FoodGroups.First(fg => fg.Name == "fruit").Id;

        return [
            new Food
        {
            Name = "tomato",
            FromInitialSeed = true,
            FoodGroupId = vegetable,
            CreatedBy = Admin.Id
        },
        new Food
        {
            Name = "pasta",
            FromInitialSeed = true,
            FoodGroupId = carbohydrate,
            CreatedBy = Admin.Id
        },
        new Food
        {
            Name = "onion",
            FromInitialSeed = true,
            FoodGroupId = vegetable,
            CreatedBy = Admin.Id
        },
        new Food
        {
            Name = "courgette",
            FromInitialSeed = true,
            FoodGroupId = vegetable,
            CreatedBy = Admin.Id
        },
        new Food
        {
            Name = "carrot",
            FromInitialSeed = true,
            FoodGroupId = vegetable,
            CreatedBy = Admin.Id
        },
        new Food
        {
            Name = "red pepper",
            FromInitialSeed = true,
            FoodGroupId = vegetable,
            CreatedBy = Admin.Id
        },
        new Food
        {
            Name = "parmesan cheese",
            FromInitialSeed = true,
            FoodGroupId = protein,
            CreatedBy = Admin.Id
        },
    ];
    }

    public List<UserFood> CreateUserFoods()
    {
        List<UserFood> userFoods = [];
        foreach (var food in Foods)
        {
            UserFood userFood = new()
            {
                UserId = Admin.Id,
                FoodId = food.Id
            };
            userFoods.Add(userFood);
        }
        return userFoods;
    }
}
