using ShopBasketLibrary.Entities;
using System.Collections.Generic;

namespace ShopBasketLibrary.Abstract
{
    public interface IBasketRepository
    {
        IEnumerable<Basket> Baskets { get; }
    }
}
