using ShopBasketLibrary.Abstract;
using ShopBasketLibrary.Entities;
using System.Collections.Generic;

namespace ShopBasketLibrary.Concrete
{

    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

        public void SaveProduct(Product product)
        {
            if (product.Id == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry = context.Products.Find(product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.PriceNetto = product.PriceNetto;
                    dbEntry.ProducerId = product.ProducerId;
                }
            }
            context.SaveChanges();
        }

        public Product DeleteProduct(int Id)
        {
            Product dbEntry = context.Products.Find(Id);
            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
