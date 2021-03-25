using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI_Tour.Control
{
    public class TourHelper
    {
        ITourService tourService;
        public TourHelper(ITourService serve)
        {
            tourService = serve;
        }

    }
}