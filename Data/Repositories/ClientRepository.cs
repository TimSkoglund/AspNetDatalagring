using Data.Contexts;
using Data.Entities;
using Domain.Models;

namespace Data.Repositories;

public interface ICientRepository : IBaseRepository<ClientEntety, Client>
{
}

public class ClientRepository(AppDbContext context) : BaseRepository<ClientEntety, Client>(context), ICientRepository
{
}
