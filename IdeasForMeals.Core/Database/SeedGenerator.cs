using IdeasForMeals.Core.Database.Entities;

namespace IdeasForMeals.Core.Database;

public class SeedGenerator
{
    public User Admin { get; init; }
    public List<FoodGroup> FoodGroups { get; init; }
    public List<Food> Foods { get; init; }
    public List<UserFood> UserFoods { get; init; }

    public SeedGenerator()
    {
        Admin = new User { IdAuth0 = "auth0|admin" };
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
        Guid carbohydrate = FoodGroups[0].Id;
        Guid protein = FoodGroups[1].Id;
        Guid vegetable = FoodGroups[2].Id;
        Guid fruit = FoodGroups[3].Id;

        return [
            #region carbohydrate 
            new Food
            {
                Name = "wholegrain pasta",
                FromInitialSeed = true,
                FoodGroupId = carbohydrate,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "wholegrain rice",
                FromInitialSeed = true,
                FoodGroupId = carbohydrate,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "potato",
                FromInitialSeed = true,
                FoodGroupId = carbohydrate,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "sweet potato",
                FromInitialSeed = true,
                FoodGroupId = carbohydrate,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "lentil",
                FromInitialSeed = true,
                FoodGroupId = carbohydrate,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "quinoa",
                FromInitialSeed = true,
                FoodGroupId = carbohydrate,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "corn",
                FromInitialSeed = true,
                FoodGroupId = carbohydrate,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "pita bread",
                FromInitialSeed = true,
                FoodGroupId = carbohydrate,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "tortilla",
                FromInitialSeed = true,
                FoodGroupId = carbohydrate,
                CreatedBy = Admin.Id
            },
            #endregion
            #region vegetable
            new Food
            {
                Name = "tomato",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
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
                Name = "bell pepper",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "button mushroom",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "oyster mushroom",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "endive",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "brussels sprout",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "green cabbage",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "kale",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "white cabbage",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "red cabbage",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "cauliflower",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "chinese cabbage",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "parsnip",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "leek",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "radish",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "beetroot",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "celeriac",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "celery stalk",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "white celery",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "turnip",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "butternut squash",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "jerusalem artichoke",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "asparagus",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "spinach",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "chard",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "broccoli",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "pea",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "eggplant",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "cucumber",
                FromInitialSeed = true,
                FoodGroupId = vegetable,
                CreatedBy = Admin.Id
            },
            #endregion
            #region fruit
            new Food
            {
                Name = "apple",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "banana",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "orange",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "mandarin orange",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "pear",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "strawberry",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "raspberry",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "fig",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "peach",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "melon",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "plum",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "apricot",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "grape",
                FromInitialSeed = true,
                FoodGroupId = fruit,
                CreatedBy = Admin.Id
            },
            #endregion
            #region protein
            new Food
            {
                Name = "egg",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "greek yoghurt",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "cottage cheese",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "pecorino",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "mozzarella",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "gouda cheese",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "edam cheese",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "gruyere cheese",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "tofu",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "soya protein",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "seitan",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "falafel",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "quorn",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "tempeh",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "black bean",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "chickpea",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "cashew nut",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "chicken breast",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "pork tenderloin",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "salmon fillet",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "rump steak",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            new Food
            {
                Name = "minced turkey",
                FromInitialSeed = true,
                FoodGroupId = protein,
                CreatedBy = Admin.Id
            },
            #endregion
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
