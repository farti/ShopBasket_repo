using ShopBasketLibrary.Abstract;
using ShopBasketLibrary.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ShopBasketLibrary.Concrete
{

    public class EFProducerRepository : IProducerRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Producer> Producers
        {
            get { return context.Producers; }
        }
    }

}
