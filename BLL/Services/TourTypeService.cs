using AutoMapper;
using BLL.DTO;
using BLL.Infostructure;
using BLL.Interfaces;
using BLL.Json.Serialize;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TourTypeService:ITourTypeService
    {
        IUnitOfWork Database { get; set; }
        public TourTypeService(IUnitOfWork data)
        {
            Database = data;
        }
        public IEnumerable<TourTypeDTO> GetTourTypes()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourType, TourTypeDTO>()).CreateMapper();
            //ISerialize<TourTypeDTO> serialize = new TourTypeSerialize();

            //IEnumerable<TourTypeDTO> i = mapper.Map<IEnumerable<TourType>, List<TourTypeDTO>>(Database.TourTypes.GetAll());
            //string[] n = serialize.serializeList(i);

            return mapper.Map<IEnumerable<TourType>, List<TourTypeDTO>>(Database.TourTypes.GetAll());//n;
        }
        public TourTypeDTO GetTourType(int? id)
        {
            if (id == null)
                throw new ValidationException("It doesn`t exist - tourtype id", "");
            var tour = Database.TourTypes.Get(id.Value);
            if (tour == null)
                throw new ValidationException("Tour is not found", "");

            //ISerialize<TourTypeDTO> serialize = new TourTypeSerialize();
            //string data = serialize.serializeVary(new TourTypeDTO { Id = tour.Id, Type = tour.Type });

            return new TourTypeDTO { Id = tour.Id, Type = tour.Type };
        }
        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
