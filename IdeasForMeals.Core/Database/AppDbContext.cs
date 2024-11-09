using IdeasForMeals.Core.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<FoodGroup> FoodGroups { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<UserFood> UserFoods { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Food>().HasIndex(f => f.Name).IsUnique();
        modelBuilder.Entity<Food>().Property(f => f.FromInitialSeed).HasDefaultValue(false);

        modelBuilder.Entity<User>().HasIndex(u => u.Alias).IsUnique();

        // Composite PK
        modelBuilder.Entity<UserFood>().HasKey(uf => new { uf.UserId, uf.FoodId });
        // Many-to-Many
        modelBuilder.Entity<UserFood>().HasOne(uf => uf.Food).WithMany(uf => uf.UserFoods).HasForeignKey(uf => uf.FoodId);
        modelBuilder.Entity<UserFood>().HasOne(uf => uf.User).WithMany(uf => uf.UserFoods).HasForeignKey(uf => uf.UserId);

        modelBuilder.Entity<UserFood>().Property(uf => uf.IsCurrentDiet).HasDefaultValue(true);

        modelBuilder.Seed();
    }
}
