using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using Moq;
using TheBeautyShop1.Domain.Abstract;
using TheBeautyShop1.Domain.Entities;
using TheBeautyShop1.Domain.Concrete;
using TheBeautyShop1.WebUI.Infrastructure.Abstract;
using TheBeautyShop1.WebUI.Infrastructure.Concrete;

namespace TheBeautyShop1.WebUI.Infrastructure
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
            kernel.Bind<IProductRepository>().To<EFProductRepository>();

            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();

        }
    }
    
}