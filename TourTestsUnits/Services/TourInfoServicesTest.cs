using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.DTO;
using BLL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using NUnit.Framework;

namespace TourTestsUnits.Services
{
    [TestFixture]
    public class TourInfoServicesTest
    {
        Mock<IUnitOfWork> mock = new Mock<IUnitOfWork>();
        List<TourInfo> info;
        [SetUp]
        public void Setup()
        {
            info = new List<TourInfo>
            {
                new TourInfo(){Id = 1, Info = "Perfect"},
                new TourInfo(){Id = 2, Info = "Super"},
                new TourInfo(){Id = 3, Info = "Ugly"},
                new TourInfo(){Id = 4, Info = "Terrible"}
            };
        }
        [Test]
        public void MakeInfo_CapableReturned()
        {
            var mock = new Mock<IUnitOfWork>();
            TourInfoDTO infoDTO = new TourInfoDTO() { Info = "Possible to deal" };
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourInfoDTO, TourInfo>()).CreateMapper();
            mock.Setup(m => m.TourInfos.GetAll()).Returns(info);
            TourInfoService service = new TourInfoService(mock.Object);

            service.MakeInfo((infoDTO));//JsonSerializer.Serialize

            var data = mapper.Map<TourInfoDTO, TourInfo>(infoDTO);
            info.Add(data);

            Assert.AreEqual(info.Count(), 5);
        }
        [Test]
        public void GetTourInfos_ArrayReturned()
        {
            mock.Setup(m => m.TourInfos.GetAll()).Returns(info);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourInfo, TourInfoDTO>()).CreateMapper();
            TourInfoService service = new TourInfoService(mock.Object);
            //ISerialize<TourInfoDTO> serialize = new TourInfoSerialize();

            //string[] example = serialize.serializeList(mapper.Map<IEnumerable<TourInfo>, List<TourInfoDTO>>(info));

            IEnumerable<TourInfoDTO> data = service.GetTourInfos();

            Assert.AreEqual(data.Count(), info.Count());
        }
        [Test]
        public void GetTourInfoById_stringValueReturned()
        {
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(m => m.TourInfos.Get(1)).Returns(info.ElementAt(0));
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourInfo, TourInfoDTO>()).CreateMapper();
            TourInfoService country = new TourInfoService(mock.Object);

            //ISerialize<TourInfoDTO> serialize = new TourInfoSerialize();
            //string example = serialize.serializeVary(mapper.Map<TourInfo, TourInfoDTO>(info.ElementAt(0)));

            TourInfoDTO data = country.GetTourInfo(1);

            Assert.IsNotNull(data);
        }
    }
}
