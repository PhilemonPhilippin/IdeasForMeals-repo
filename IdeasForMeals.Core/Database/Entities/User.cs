using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Database.Entities;

public class User : DateMetadata
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Alias { get; set; }

    public ICollection<UserFood> UserFoods { get; set; } = new List<UserFood>();

    public User()
    {
        Id = Guid.NewGuid();
    }
}
