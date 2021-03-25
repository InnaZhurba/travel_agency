using BLL.Interfaces;
using BLL.Infostructure;
using DAL.Entities;
using BLL.DTO;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Json.Deserialize;
using BLL.Json.Serialize;

namespace BLL.Services
{
    public class TourService : ITourService
    {
        IUnitOfWork Database { get; set; }
        //IDeserialize<TourDTO> deserialize;
        //ISerialize<TourDTO> serialize;
        public TourService(IUnitOfWork data)
        {
            Database = data;
        }
        public void MakeTour(TourDTO tourDTO)//(TourDTO tourDTO)
        {
            //deserialize = new TourDeserialize();
            //TourDTO tourDTO = deserialize.deserializeVary(TourVary);

            TourType type = Database.TourTypes.Get(tourDTO.TourTypeId);
            TourInfo info = Database.TourInfos.Get(tourDTO.InfoId);

            if (type == null || info == null)
                throw new ValidationException("Data - info/type is not found", "");
            Tour tour = new Tour
            {
                Name = tourDTO.Name,
                TourTypeId = tourDTO.TourTypeId,
                InfoId = tourDTO.InfoId,
            };
            Database.Tours.Create(tour);
            Database.Save();
        }
        public void EditTour(TourDTO tourDTO)//(TourDTO tourDTO)
        {            
            //deserialize = new TourDeserialize();
            //TourDTO tourDTO = deserialize.deserializeVary(TourVary);

            TourType type = Database.TourTypes.Get(tourDTO.TourTypeId);
            TourInfo info = Database.TourInfos.Get(tourDTO.InfoId);

            if (type == null || info == null)
                throw new ValidationException("Data - info/type is not found", "");
            Tour tour = new Tour
            {
                Id = tourDTO.Id,
                Name = tourDTO.Name,
                TourTypeId = tourDTO.TourTypeId,
                InfoId = tourDTO.InfoId,
            };
            Database.Tours.Update(tour);
            Database.Save();
        }
        public IEnumerable<TourDTO> GetTours()//IEnumerable<TourDTO> GetTours()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Tour, TourDTO>()).CreateMapper();
           //serialize = new TourSerialize();

            //IEnumerable<TourDTO> i = mapper.Map<IEnumerable<Tour>, List<TourDTO>>(Database.Tours.GetAll());
            //string[] n = serialize.serializeList(i);

            return mapper.Map<IEnumerable<Tour>, List<TourDTO>>(Database.Tours.GetAll());
        }       
        public TourDTO GetTour(int? id)
        {
            if (id == null)
                throw new ValidationException("It doesn`t exist - tour id", "");
            var tour = Database.Tours.Get(id.Value);
            if (tour == null)
                throw new ValidationException("Tour is not found", "");

            //ISerialize<TourDTO> serialize = new TourSerialize();
            //string data = serialize.serializeVary(new TourDTO { Id = tour.Id, Name = tour.Name , TourTypeId = tour.TourTypeId, InfoId = tour.InfoId});

            return new TourDTO { Id = tour.Id, Name = tour.Name, TourTypeId = tour.TourTypeId, InfoId = tour.InfoId };
        }     
       
        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
