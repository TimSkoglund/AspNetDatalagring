using Buisness.Models;
using Data.Repositories;
using Domain.Extensions;

namespace Buisness.Services;

public interface IClientService
{
    Task<ClientResult> GetClientsAsync();
}

public class ClientService(ICientRepository clientRepository) : IClientService
{
    private readonly ICientRepository _clientRepository = clientRepository;
    public async Task<ClientResult> GetClientsAsync()
    {
        var result = await _clientRepository.GetAllAsync();
        return result.MapTo<ClientResult>();
    }
}
