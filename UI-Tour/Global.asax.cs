using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace UI_Tour
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ////NinjectModule tourModule = new TourModule();
            //NinjectModule countryModule = new CountryModule();
            //NinjectModule listOCModule = new ListOCModule();
            ////NinjectModule serviceModule = new ServiceModule("DBConnection");


            //var kernel = new StandardKernel(listOCModule, serviceModule);
            //DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));

            ////var kerneltwo = new StandardKernel(tourModule, serviceModule);
            ///
            //NinjectModule registrations = new NinjectRegistrations();
            //var kernel = new StandardKernel(registrations, serviceModule);
            //DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));


            //GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kerneltwo);

            //var kernelthree = new StandardKernel(countryModule, serviceModule);
            //DependencyResolver.SetResolver(new NinjectDependencyResolver(kernelthree));
        }
        
    }
}
