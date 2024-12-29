using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Data 
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        
        public DbSet<PersonalInfo> Personal_Info { get; set; }
    }

}
