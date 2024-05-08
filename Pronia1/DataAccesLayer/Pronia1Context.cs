using Microsoft.EntityFrameworkCore;
using Pronia1.Models;

namespace Pronia1.DataAccesLayer
{
    public class Pronia1Context : DbContext
    {
        public Pronia1Context(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category>Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-8V62CRJ\\SQLEXPRESS;Database=Pronia;Trusted_Connection=True;TrustServerCertificate = True");
            base.OnConfiguring(options);
        }
    }
}
