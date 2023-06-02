using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TesteSebrae.Domain.Entities;

namespace TesteSebrae.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        /*protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }*/

        public DbSet<ContaDTO> Conta { get; set; }
    }
}
