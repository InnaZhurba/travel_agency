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
    public class RegionService:IRegionService
    {
        IUnitOfWork Database;
        public RegionService(IUnitOfWork data)
        {
            Database = data;
        }
        public IEnumerable<RegionDTO> GetRegions()//IEnumerable<RegionDTO> GetRegions()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Region, RegionDTO>()).CreateMapper();
            //ISerialize<RegionDTO> serialize = new RegionSerialize();

            //IEnumerable<RegionDTO> i = mapper.Map<IEnumerable<Region>, List<RegionDTO>>(Database.Regions.GetAll());
            //string[] n = serialize.serializeList(i);
            return mapper.Map<IEnumerable<Region>, List<RegionDTO>>(Database.Regions.GetAll());//n;
        }
        public RegionDTO GetRegion(int? id)//RegionDTO GetRegion(int? id)
        {
            if (id == null)
                throw new ValidationException("It doesn`t exist - region id", "");
            var region = Database.Regions.Get(id.Value);
            if (region == null)
                throw new ValidationException("Region is not found", "");

            //ISerialize<RegionDTO> serialize = new RegionSerialize();
            //string data = serialize.serializeVary(new RegionDTO { Id = region.Id, Name = region.Name, });

            return new RegionDTO { Id = region.Id, Name = region.Name, };//data;
        }
        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
