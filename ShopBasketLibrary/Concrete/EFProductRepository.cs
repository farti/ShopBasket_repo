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
    }
}
