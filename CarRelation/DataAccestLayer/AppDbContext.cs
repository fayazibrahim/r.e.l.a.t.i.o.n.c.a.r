using CarRelation.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CarRelation.DataAccestLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
         public DbSet<Marka> Marka { get; set; }
        public DbSet<Model> Model { get; set; }

        public DbSet<Car> Car { get; set; }
    }
}
