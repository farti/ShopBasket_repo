using ShopBasketLibrary.Entities;
using System.Data.Entity;


namespace ShopBasketLibrary.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
