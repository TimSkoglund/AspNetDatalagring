using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

[Index(nameof(ClientName), IsUnique = true)]
public class ClientEntety
{
    [Key]
    public string Id { get; set; } = null!;
    public string ClientName { get; set; } = null!;

    public virtual ICollection<ProjectEntety> Projects { get; set; } = [];
}
