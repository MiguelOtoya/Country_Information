using Country_Information.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Country_Information.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
         public DbSet<Country> Countries { get; set; }
         public DbSet<Continent> Continents { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>().HasData(
                new Continent
                {
                    id = 1,
                    name = "America",
                    description = "The only one who aliens invade"
                },
                new Continent
                {
                    id = 2,
                    name = "Europe",
                    description = "The third most populous continent"
                },
                new Continent
                {
                    id = 3,
                    name = "Asia",
                    description = "The largest continent"
                },
                new Continent
                {
                    id = 4,
                    name = "Oceania",
                    description = "kangaroos"
                },
                new Continent
                {
                    id = 5,
                    name = "Africa",
                    description = "The N word"
                });
                
        }

    }

    
}
