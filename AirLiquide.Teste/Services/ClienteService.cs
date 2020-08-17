using Microsoft.Extensions.Logging;
using AirLiquide.Teste.Models;
using AirLiquide.Teste.Repositories;

namespace AirLiquide.Teste.Services
{
    public class ClienteService : Service<Cliente>
    {
        protected IRepository<Cliente> _repository;
        public ClienteService(IRepository<Cliente> repository, ILogger<ClienteService> logger) : base(repository, logger)
        {
            _repository = repository;
        }
    }
}
