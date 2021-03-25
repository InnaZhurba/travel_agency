using DAL_Order.Interfaces;
using DAL_Order.UoW;
using Ninject.Modules;

namespace BLL_Order.Infostructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWorkOrder>().To<UnitOfWorkOrder>().WithConstructorArgument(connectionString);
        }
    }
}
