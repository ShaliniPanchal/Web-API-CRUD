using Microsoft.EntityFrameworkCore;
using ProductCRUDApp.Models;

namespace ProductCRUDApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
