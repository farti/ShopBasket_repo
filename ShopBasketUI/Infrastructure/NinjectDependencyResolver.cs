using Moq;
using Ninject;
using ShopBasketLibrary.Abstract;
using ShopBasketLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;




namespace ShopBasketUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);

        }

        private void AddBindings()
        {
            // librarry of connections and fake bases here

            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product> {
                new Product { Id = 1, Name = "Sól", Description = "Słona przyprawa.", ProducerId = 1},
                new Product { Id = 2, Name = "Pieprz", Description = "Pierna przyprawa.", ProducerId = 1},
                new Product { Id = 3, Name = "Papryka", Description = "Ostra przyprawa.", ProducerId = 2}
            });

            kernel.Bind<IProductRepository>().ToConstant(mock.Object);


        }
    }
}