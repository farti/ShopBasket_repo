using ShopBasketLibrary.Entities;
using System.Collections.Generic;

namespace ShopBasketLibrary.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int Id);
    }
}
