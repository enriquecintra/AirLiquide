using Microsoft.Extensions.DependencyInjection;
using AirLiquide.Teste.Models;

namespace AirLiquide.Teste.Repositories
{
    public class RepositoriesStartup
    {
        public static void StartupRepositories(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<Cliente>), typeof(ClienteRepository));
        }
    }
}
