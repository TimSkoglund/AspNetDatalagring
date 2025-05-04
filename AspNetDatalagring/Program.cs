using AspNetDatalagring.Components;
using Business.Mappers;
using Business.Services.Customer;
using Business.Services.Project;
using Business.Services.User;
using Data.Context;
using Data.Repositories.Customer;
using Data.Repositories.Project;
using Data.Repositories.User;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<DataContext>(opt =>
    opt.UseSqlite("Data Source=../Data/project.db"));

// CUSTOMER
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ICustomerService, CustomerService>();

// PROJECT
builder.Services.AddTransient<IProjectRepository, ProjectRepository>();
builder.Services.AddTransient<IProjectService, ProjectService>();

// USER
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<DataContext>();
    ctx.Database.Migrate();

    SeedUser(ctx);
    SeedProducts(ctx);
    SeedCustomer(ctx);

}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

void SeedUser(DataContext ctx)
{
    // Seed the database with a user if it doesn't exist

    if (ctx.Users.Any() is false)
    {
        var entity = UserMapper.Map(new RegisterUser()
        {
            Email = "tim@skoglund.com",
            FirstName = "Tim",
            LastName = "Skoglund",
            Password = "password",
            PasswordVerify = "password"
        });

        ctx.Users.Add(entity);
        ctx.SaveChanges();
    }
}

void SeedProducts(DataContext ctx)
{
    // Seed the database with products if it doesn't exist

    if (ctx.Products.Any() is false)
    {
        var enteties = ProductMapper.Map(new List<Data.Entities.Product>()
        {
            new Data.Entities.Product()
            {
                Price = 240,
                ProductName = "Road construction"
            },
            new Data.Entities.Product()
            {
                Price = 140,
                ProductName = "Flooring"
            },
            new Data.Entities.Product()
            {
                Price = 40,
                ProductName = "Consultation"
            },
        });

        ctx.Products.AddRange(enteties);
        ctx.SaveChanges();
    }
}

void SeedCustomer(DataContext ctx)
{
    if (ctx.Customers.Any() is false)
    {
        var enteties = CustomerMapper.Map(new List<Business.Models.Customer>()
        {
            new Business.Models.Customer
            {
                Name = "Brett Hull"
            },
            new Business.Models.Customer
            {
                Name = "Steven Hawkins"
            },
            new Business.Models.Customer
            {
                Name = "Jane Doe"
            },
        });

        ctx.Customers.AddRange(enteties);
        ctx.SaveChanges();
    }
}
