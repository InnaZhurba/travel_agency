using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UI.Models;

namespace UI_Tour.Models
{
    public class TourAndDetails
    {
        public Tour Tours { get; set; }
        public TourType Types { get; set; }
        public TourInfo Infos { get; set; }
        public ListOfCountry ListOfCountries { get; set; }
        public Country Countries { get; set; }
        public Region Regions { get; set; }
    }
}