using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<UserEntity>(options)
{
    public virtual DbSet<ClientEntety> Clients { get; set; }
    public virtual DbSet<StatusEntety> Statuses { get; set; }

    public virtual DbSet<ProjectEntety> Projects { get; set; }
}


