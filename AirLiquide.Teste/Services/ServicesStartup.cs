using Microsoft.Extensions.DependencyInjection;

namespace AirLiquide.Teste.Services
{
    public class ServicesStartup
    {
        public static void StartupServices(IServiceCollection services)
        {
            services.AddScoped<ClienteService>();
        }
    }
}
