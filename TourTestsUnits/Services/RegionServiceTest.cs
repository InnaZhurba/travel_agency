using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
//using BLL.Json.Serialize;
using BLL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTestsUnits.Services
{
    [TestFixture]
    public class RegionServiceTest
    {
        Mock<IUnitOfWork> mock = new Mock<IUnitOfWork>();

        List<Region> exampleRegions;
        [SetUp]
        public void SetUp()
        {
            exampleRegions = new List<Region>()
            {
                new Region(){Id = 1, Name = "Georgia"},
                new Region(){Id = 2, Name = "Florida"}
            };
        }
        [Test]
        public void GetRegions_stringArrayReturned()
        {
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(m => m.Regions.GetAll()).Returns(exampleRegions);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Region, RegionDTO>()).CreateMapper();
            RegionService country = new RegionService(mock.Object);

            //ISerialize<RegionDTO> serialize = new RegionSerialize();
            IEnumerable<RegionDTO> example = mapper.Map<IEnumerable<Region>, List<RegionDTO>>(exampleRegions);//serialize.serializeList()

            IEnumerable<RegionDTO> data = country.GetRegions();

            Assert.AreEqual(data.Count(), example.Count());
        }

        [Test]
        public void GetRegionById_stringValueReturned()
        {
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(m => m.Regions.Get(1)).Returns(exampleRegions.ElementAt(0));
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Region, RegionDTO>()).CreateMapper();
            RegionService country = new RegionService(mock.Object);

           // ISerialize<RegionDTO> serialize = new RegionSerialize();
            //RegionDTO example = mapper.Map<Region, RegionDTO>(exampleRegions.ElementAt(0));//serialize.serializeVary()

            RegionDTO data = country.GetRegion(1);

            mock.Verify(lw => lw.Regions.Get(1),
    Times.Once());
            Assert.IsNotNull(data);
        }

    }
}
