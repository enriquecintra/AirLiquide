using Microsoft.Extensions.Logging;
using AirLiquide.Teste.Models;

namespace AirLiquide.Teste.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IRepository<Cliente>
    {
        private AirLiquideDbContext _dbContext;

        public ClienteRepository(AirLiquideDbContext dbContext,
                                 ILogger<ClienteRepository> logger) : base(dbContext, logger)
        {
            _dbContext = dbContext;
        }
    }
}
