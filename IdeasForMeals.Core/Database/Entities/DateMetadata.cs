using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasForMeals.Core.Database.Entities;

public abstract class DateMetadata
{
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime ModifiedAt { get; set; }

    public DateMetadata()
    {
        CreatedAt = DateTime.UtcNow;
        ModifiedAt = DateTime.UtcNow;
    }
}
