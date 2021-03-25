using System;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using AutoMapper;
using BLL.Infostructure;
using BLL.Json.Serialize;

namespace BLL.Services
{
    public class CountryService : ICountryService
    {
        IUnitOfWork Database { get; set; }

        public CountryService(IUnitOfWork data)
        {
            Database = data;
        }

        public CountryDTO GetCountry(int? id)//CountryDTO GetCountry(int? id)
        {
            if (id == null)
                throw new ValidationException("It doesn`t exist - country id", "");
            var country = Database.Countries.Get(id.Value);
            if (country == null)
                throw new ValidationException("Country is not found", "");

            //ISerialize<CountryDTO> serialize = new CountrySerialize();
            //string data = serialize.serializeVary(new CountryDTO { Name = country.Name, Id = country.Id, RegionId = country.RegionId });

            return new CountryDTO { Name = country.Name, Id = country.Id, RegionId = country.RegionId };
        }

        public IEnumerable<CountryDTO> GetCountries()//IEnumerable<CountryDTO> GetCountries()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Country, CountryDTO>()).CreateMapper();
            //ISerialize<CountryDTO> serialize = new CountrySerialize();

            //IEnumerable<CountryDTO> i = mapper.Map<IEnumerable<Country>, List<CountryDTO>>(Database.Countries.GetAll());
            //string[] n = serialize.serializeList(i);

            return mapper.Map<IEnumerable<Country>, List<CountryDTO>>(Database.Countries.GetAll());
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
