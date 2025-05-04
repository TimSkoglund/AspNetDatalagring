namespace Business.Services.Customer
{
    public interface ICustomerService
    {
        Task CreateCustomerAsync(Models.Customer customer, CancellationToken cancellation);
        Task<bool> DeleteCustomerAsync(int id, CancellationToken cancellation);
        Task<Models.Customer?> GetCustomerByCustomerNameAsync(string customerName, CancellationToken cancellation);
        Task<Models.Customer?> GetCustomerByIdAsync(int id, CancellationToken cancellation);
        Task<List<Models.Customer>> GetCustomersAsync(CancellationToken cancellation);
        Task<bool> UpdateCustomerAsync(Models.Customer customer, CancellationToken cancellation);
    }
}