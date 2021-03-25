using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.Services;
using BLL.Interfaces;

namespace UI_Tour.Util
{
    public class ListOCModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IListOCService>().To<ListOfCountryService>();
        }
    }
}