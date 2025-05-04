using Data.Context;
using Data.Entities;
using Data.Repositories.Base;

namespace Data.Repositories.Customer;

public class CustomerRepository(DataContext ctx)
    : BaseRepository<CustomerEntity>(ctx), ICustomerRepository
{ }
