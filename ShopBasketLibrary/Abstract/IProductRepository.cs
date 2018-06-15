using ShopBasketLibrary.Entities;
using System.Collections.Generic;

namespace ShopBasketLibrary.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
