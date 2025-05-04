using Business.Models;
using Data.Entities;

namespace Business.Mappers;

public static class CustomerMapper
{
    public static CustomerEntity Map(Customer customer)
    {
        return customer != null ? new CustomerEntity
        {
            Name = customer.Name,
        } : null;
    }
    
    public static Customer Map(CustomerEntity customer)
    {
        return customer != null ? new Customer
        {
            Id = customer.Id,
            Name = customer.Name
        } : null;
    }

    public static List<Customer> Map(List<CustomerEntity> customers)
    {
        return customers != null ? customers.Select(Map).ToList() : new List<Customer>();
    }
}