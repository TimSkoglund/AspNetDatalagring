using Business.Mappers;
using Data.Repositories.Customer;

namespace Business.Services.Customer;

public class CustomerService(ICustomerRepository repo) : ICustomerService
{
    public async Task CreateCustomerAsync(Models.Customer customer, CancellationToken cancellation)
    {
        await repo.AddAsync(CustomerMapper.Map(customer), cancellation);
    }

    public async Task<List<Models.Customer>> GetCustomersAsync(CancellationToken cancellationToken)
    {
        var entities = await repo.GetAsync(cancellationToken);
        
        if (entities == null || !entities.Any())
            return new List<Models.Customer>();
        
        return CustomerMapper.Map(entities);
    }

    public async Task<Models.Customer?> GetCustomerByIdAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await repo.GetAsync(x => x.Id == id, cancellationToken);
        return CustomerMapper.Map(entity!);
    }

    public async Task<Models.Customer?> GetCustomerByCustomerNameAsync(string name, CancellationToken cancellationToken)
    {
        var entity = await repo.GetAsync(x => x.Name == name , cancellationToken);
        return CustomerMapper.Map(entity!);
    }

    // TODO: implementera uppdatering & borttag
    public Task<bool> UpdateCustomerAsync(Models.Customer c, CancellationToken cancellationToken) => throw new NotImplementedException();
    public Task<bool> DeleteCustomerAsync(int id, CancellationToken cancellationToken)   => throw new NotImplementedException();
}
