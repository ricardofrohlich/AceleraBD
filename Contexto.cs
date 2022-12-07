using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Data
{
    public class Contexto : DbContext 
    {
        public DbSet<Pessoa> Pessoas { get; set; }


        public Contexto()
        {
            //Add-Migration Initial
            //Update-Database
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"server=localhost;Port=5432;User ID=postgres;password=admin;database=BD0712");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
