using ApiCerealCDA.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCerealCDA
{
    public class CerealDbContext : DbContext
    {
        public DbSet<Cereal> Cereals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(LocalDB)\mssqllocaldb;Database=dbcereals");
        }
    }
}
