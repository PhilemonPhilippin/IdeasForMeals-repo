using IdeasForMeals.Core.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdeasForMeals.Core.Database;

public static class DbSeed
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        SeedGenerator seed = new();

        modelBuilder.Entity<User>().HasData(seed.Admin);
        modelBuilder.Entity<FoodGroup>().HasData(seed.FoodGroups);
        modelBuilder.Entity<Food>().HasData(seed.Foods);
        modelBuilder.Entity<UserFood>().HasData(seed.UserFoods);
    }
}
