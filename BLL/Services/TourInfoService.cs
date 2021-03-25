using System;
using BLL.Interfaces;
using BLL.Infostructure;
using BLL.DTO;
using DAL.Interfaces;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Json.Deserialize;
using AutoMapper;
using BLL.Json.Serialize;

namespace BLL.Services
{
    public class TourInfoService : ITourInfoService
    {
        IUnitOfWork Database { get; set; }
        //IDeserialize<TourInfoDTO> deserialize;

        public TourInfoService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void MakeInfo(TourInfoDTO tourInfoDTO)//(TourInfoDTO tourInfoDTO)
        {
           // deserialize = new TourInfoDeserialize();
            //TourInfoDTO tourInfoDTO = deserialize.deserializeVary(data);

            TourInfo info = new TourInfo
            {
                Info = tourInfoDTO.Info,
            };
            Database.TourInfos.Create(info);
            Database.Save();
        }
        public IEnumerable<TourInfoDTO> GetTourInfos()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourInfo, TourInfoDTO>()).CreateMapper();
            //ISerialize<TourInfoDTO> serialize = new TourInfoSerialize();

            //IEnumerable<TourInfoDTO> i = mapper.Map<IEnumerable<TourInfo>, List<TourInfoDTO>>(Database.TourInfos.GetAll());
            //string[] n = serialize.serializeList(i);

            return mapper.Map<IEnumerable<TourInfo>, List<TourInfoDTO>>(Database.TourInfos.GetAll());
        }
        public TourInfoDTO GetTourInfo(int? id)
        {
            if (id == null)
                throw new ValidationException("It doesn`t exist - tour id", "");
            var tour = Database.TourInfos.Get(id.Value);
            if (tour == null)
                throw new ValidationException("Tour is not found", "");

            //ISerialize<TourInfoDTO> serialize = new TourInfoSerialize();
            //string data = serialize.serializeVary(new TourInfoDTO { Id = tour.Id, Info = tour.Info });

            return new TourInfoDTO { Id = tour.Id, Info = tour.Info };
        }
        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
