using System;
using BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICountryService
    {
        CountryDTO GetCountry(int? id);//RegionDTO GetRegion(int? id);//регион по id
        IEnumerable<CountryDTO> GetCountries();//IEnumerable<RegionDTO> GetRegions();//все регионы
        void Dispose();
    }
}
