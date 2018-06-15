using ShopBasketLibrary.Entities;
using System.Collections.Generic;

namespace ShopBasketLibrary.Abstract
{
    public interface IProducerRepository
    {
        IEnumerable<Producer> Producers { get; }
    }
}
