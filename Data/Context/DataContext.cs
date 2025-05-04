using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<CustomerEntity> Customers  => Set<CustomerEntity>();
    public DbSet<ProductEntity>  Products   => Set<ProductEntity>();
    public DbSet<StatusTypeEntity> StatusTypes => Set<StatusTypeEntity>();
    public DbSet<UserEntity>    Users      => Set<UserEntity>();
}