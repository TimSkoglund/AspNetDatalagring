using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

[Index(nameof(StatusName), IsUnique = true)]
public class StatusEntety
{
    [Key]
    public int Id { get; set; }
    public string StatusName { get; set; } = null!;
    
    public virtual ICollection<ProjectEntety> Projects { get; set; } = [];
}