using System;
using BLL.DTO;
using DAL.Interfaces;
using DAL.Entities;
using BLL.Infostructure;
using BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Json;
using BLL.Json.Serialize;
using BLL.Json.Deserialize;

namespace BLL.Services
{
    public class ListOfCountryService : IListOCService
    {
        IUnitOfWork Database { get; set; }
        //IDeserialize<ListOfCountryDTO> deserialize;
        public ListOfCountryService(IUnitOfWork data)
        {
            Database = data;
        }
        public IEnumerable<ListOfCountryDTO> GetListOC()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountry, ListOfCountryDTO>()).CreateMapper();
            //ISerialize<ListOfCountryDTO> serialize = new ListOCSerialize();

            //IEnumerable<ListOfCountryDTO> i = mapper.Map<IEnumerable<ListOfCountry>, List<ListOfCountryDTO>>(Database.ListOfCountries.GetAll());
            //string[] n = serialize.serializeList(i);

            return mapper.Map<IEnumerable<ListOfCountry>, List<ListOfCountryDTO>>(Database.ListOfCountries.GetAll());
        }
        public void MakeList(ListOfCountryDTO listOCDDTO)//(ListOfCountryDTO listOCDDTO)
        {
            //IDeserialize<ListOfCountryDTO> deserializeList = new ListOCDeserialize();
            //ListOfCountryDTO listOCDDTO = deserializeList.deserializeVary(data);

            Tour tour = Database.Tours.Get(listOCDDTO.TourId);
            Country country = Database.Countries.Get(listOCDDTO.CountryId);

            // валидация
            if (tour == null || country == null)
                throw new ValidationException("Data - country/tour is not found", "");
            ListOfCountry listOC = new ListOfCountry
            {
                TourId = listOCDDTO.TourId,
                CountryId = listOCDDTO.CountryId,
            };
            Database.ListOfCountries.Create(listOC);
            Database.Save();
        }

        public ListOfCountryDTO GetListOC(string id)
        {
            if (id == null)
                throw new ValidationException("It doesn`t exist - tour id", "");
            var tour = Database.ListOfCountries.GetName(id);
            if (tour == null)
                throw new ValidationException("List is not found", "");

            //ISerialize<ListOfCountryDTO> serialize = new ListOCSerialize();
            //string data = serialize.serializeVary(new ListOfCountryDTO { Id = tour.ToArray()[0].Id, CountryId = tour.ToArray()[0].CountryId, TourId = tour.ToArray()[0].TourId });

            return new ListOfCountryDTO { Id = tour.ToArray()[0].Id, CountryId = tour.ToArray()[0].CountryId, TourId = tour.ToArray()[0].TourId }; 
        }
        public ListOfCountryDTO GetListOC(int? id)
        {
            if (id == null)
                throw new ValidationException("It doesn`t exist - tour id", "");
            var tour = Database.ListOfCountries.Get(id.Value);
            if (tour == null)
                throw new ValidationException("Tour is not found", "");

            //ISerialize<ListOfCountryDTO> serialize = new ListOCSerialize();
            //string data = serialize.serializeVary(new ListOfCountryDTO { Id = tour.Id, CountryId = tour.CountryId, TourId = tour.TourId });

            return new ListOfCountryDTO { Id = tour.Id, CountryId = tour.CountryId, TourId = tour.TourId };
        }
        public void EditListOC(ListOfCountryDTO DTO)//(TourDTO tourDTO)
        {
            //ListOCDeserialize deserialize = new ListOCDeserialize();
            //ListOfCountryDTO DTO = deserialize.deserializeVary(Vary);

            Tour tour = Database.Tours.Get(DTO.TourId);

            if (tour == null)
                throw new ValidationException("Data - info/type is not found", "");
            ListOfCountry data = new ListOfCountry
            {
                Id = DTO.Id,
                CountryId = DTO.CountryId,
                TourId = DTO.TourId,
            };
            Database.ListOfCountries.Update(data);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
