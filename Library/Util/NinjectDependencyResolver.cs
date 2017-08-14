using Library.BLL.Interfaces;
using Library.BLL.Services;
using Library.DAL.Entities;
using Library.DAL.Interfaces;
using Library.DAL.Repository;
using Library.DAL.UnitOfWork;
using Library.MyNinjectModules;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IBookService>().To<BookService>();
            kernel.Bind<IRepository<Book>>().To<EFRepository<Book>>();
            kernel.Bind<IUnitOfWork>().To<EFUnitOfWork>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}