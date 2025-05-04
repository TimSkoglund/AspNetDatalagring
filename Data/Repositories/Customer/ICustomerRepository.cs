using Data.Entities;
using Data.Repositories.Base;

namespace Data.Repositories.Customer
{
    public interface ICustomerRepository : IBaseRepository<CustomerEntity>
    { }
}