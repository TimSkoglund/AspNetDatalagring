using Microsoft.AspNetCore.Identity;
using System.Collections;

namespace Data.Entities;

public class UserEntity : IdentityUser 
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? JobTitle { get; set; }

    public virtual ICollection<ProjectEntety> Projects { get; set; } = [];
}
