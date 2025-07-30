using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=YAREN;Database=northwind;Integrated Security=True;TrustServerCertificate=True");
            }
        }
    }
}
