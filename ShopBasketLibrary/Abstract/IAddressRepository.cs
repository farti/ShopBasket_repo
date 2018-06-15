using ShopBasketLibrary.Entities;
using System.Collections.Generic;

namespace ShopBasketLibrary.Abstract
{
    public interface IAddressRepository
    {
        IEnumerable<Basket> Baskets { get; }
    }
}
