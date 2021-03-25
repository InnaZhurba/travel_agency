using BLL.Interfaces;
using BLL.Services;
using Ninject;
using System.Web.Http.Dependencies;

namespace UI_Tour.Util
{
    public class NinjectResolver : NinjectScope, IDependencyResolver
    {
        private readonly IKernel _kernel;
        public NinjectResolver(IKernel kernel)
            : base(kernel)
        {
            _kernel = kernel;
        }
        public IDependencyScope BeginScope()
        {
            return new NinjectScope(_kernel.BeginBlock());
        }
        private static void RegisterServices(IKernel kerneltwo)
        {
            kerneltwo.Bind<ITourService>().To<TourService>();
        }
    }
}