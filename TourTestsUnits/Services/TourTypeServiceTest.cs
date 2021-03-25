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
    public class TourTypeServiceTest
    {
        Mock<IUnitOfWork> mock = new Mock<IUnitOfWork>();

        List<TourType> types;
        [SetUp]
        public void SetUp()
        {
            types = new List<TourType>
            {
                new TourType(){Id=1, Type="Adventure"},
                new TourType(){Id=2, Type="Extra"},
                new TourType(){Id=3, Type="Lite"},
            };
        }
        [Test]
        public void GetTourTypes_ArrayReturned()
        {
            mock.Setup(m => m.TourTypes.GetAll()).Returns(types);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourType, TourTypeDTO>()).CreateMapper();
            TourTypeService service = new TourTypeService(mock.Object);
            //ISerialize<TourTypeDTO> serialize = new TourTypeSerialize();

            IEnumerable<TourTypeDTO> example = (mapper.Map<IEnumerable<TourType>, List<TourTypeDTO>>(types));//serialize.serializeList

            IEnumerable<TourTypeDTO> data = service.GetTourTypes();

            Assert.AreEqual(data.Count(), example.Count());
        }
        [Test]
        public void GetTourTypeById_stringValueReturned()
        {
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(m => m.TourTypes.Get(1)).Returns(types.ElementAt(0));
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourType, TourTypeDTO>()).CreateMapper();
            TourTypeService country = new TourTypeService(mock.Object);

            //ISerialize<TourTypeDTO> serialize = new TourTypeSerialize();
            TourTypeDTO example = (mapper.Map<TourType, TourTypeDTO>(types.ElementAt(0)));//serialize.serializeVary

            TourTypeDTO data = country.GetTourType(1);

            Assert.IsNotNull(data);
        }

    }
}
