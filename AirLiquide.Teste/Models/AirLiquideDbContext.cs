using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AirLiquide.Teste.Models
{
    public class AirLiquideDbContext : DbContext
    {
        private IConfiguration _configuration;

        public AirLiquideDbContext(IConfiguration configuration,
                                    DbContextOptions options)
            : base(options)
        {
            _configuration = configuration;
        }
        public virtual DbSet<Cliente> Cliente { get; set; }
    }
}
