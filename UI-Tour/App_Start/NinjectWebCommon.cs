[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(UI_Tour.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(UI_Tour.App_Start.NinjectWebCommon), "Stop")]

namespace UI_Tour.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using BLL.Interfaces;
    using BLL_Order.Interfaces;
    using BLL.Services;
    using DAL.Interfaces;
    using DAL.UoW;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Ninject.Web.WebApi;
    using DAL_Order.Interfaces;
    using DAL_Order.UoW;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);

                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);

                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument("DBConnection");
            kernel.Bind<IUnitOfWorkOrder>().To<UnitOfWorkOrder>().WithConstructorArgument("DBConnection");
            kernel.Bind<ITourService>().To<TourService>();
            kernel.Bind<ICountryService>().To<CountryService>();
            kernel.Bind<IListOCService>().To<ListOfCountryService>();
            kernel.Bind<ITourInfoService>().To<TourInfoService>();
            kernel.Bind<ITourTypeService>().To<TourTypeService>();
            kernel.Bind<IRegionService>().To<RegionService>();
            kernel.Bind<IOrderService>().To<OrderService>();
            kernel.Bind<ITourAndDetailsService>().To<TourAndDetailsService>();
        }
    }
}