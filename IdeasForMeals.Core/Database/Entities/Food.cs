using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Database.Entities;

public class Food : DateMetadata
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }
    public bool FromInitialSeed { get; set; }

    [ForeignKey(nameof(FoodGroup))]
    public Guid FoodGroupId { get; set; }
    public FoodGroup FoodGroup { get; set; }

    [ForeignKey(nameof(User))]
    public Guid? CreatedBy { get; set; }
    public User? User { get; set; }

    public ICollection<UserFood> UserFoods { get; set; } = new List<UserFood>();

    public Food()
    {
        Id = Guid.NewGuid();
    }
}
