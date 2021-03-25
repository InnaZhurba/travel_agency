using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL.DTO
{
    public class TourAndDetailsDTO
    {
        public TourDTO Tours { get; set; }
        public TourTypeDTO Types { get; set; }
        public TourInfoDTO Infos { get; set; }
        public ListOfCountryDTO ListOfCountries { get; set; }
        public CountryDTO Countries { get; set; }
        public RegionDTO Regions { get; set; }
    }
}