using CRUDUsingDBCodeFirstCore.Models.Entitys;
using Microsoft.EntityFrameworkCore;

namespace CRUDUsingDBCodeFirstCore.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; } 

    }
}
