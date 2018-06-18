using Ninject;
using ShopBasketLibrary.Abstract;
using ShopBasketLibrary.Concrete;
using System;
using System.Collections.Generic;
using System.Web.Mvc;




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
            // librarry of connections  here

            kernel.Bind<IProductRepository>().To<EFProductRepository>();
            kernel.Bind<IProducerRepository>().To<EFProducerRepository>();


        }
    }
}