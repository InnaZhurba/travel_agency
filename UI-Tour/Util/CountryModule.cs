using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI_Tour.Util
{
    public class CountryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICountryService>().To<CountryService>();
        }
    }
}