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
    public class ListOCServiceTest
    {
        Mock<IUnitOfWork> mock = new Mock<IUnitOfWork>();
        List<ListOfCountry> list;
        Tour tour;
        Country country;

        [SetUp]
        public void Setup()
        {
            list = new List<ListOfCountry>
            {
                new ListOfCountry(){Id = 1, CountryId = 2, TourId = 3,},
                new ListOfCountry(){Id = 2, CountryId = 5, TourId = 7,},
                new ListOfCountry(){Id = 3, CountryId = 3, TourId = 2,},
                new ListOfCountry(){Id = 4, CountryId = 1, TourId = 1,}
            };
            tour = new Tour() { Id = 7, Name = "TourExample", TourTypeId = 4, InfoId = 2 };
            country = new Country() { Id = 4, Name = "USA", RegionId = 4 };
        }

        [Test]
        public void MakeList_CapableReturned()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountryDTO, ListOfCountry>()).CreateMapper();
            ListOfCountryDTO listDTO = new ListOfCountryDTO() { CountryId = 4, TourId = 7 };
            mock.Setup(m => m.Tours.Get(listDTO.TourId)).Returns(tour);
            mock.Setup(m => m.Countries.Get(listDTO.CountryId)).Returns(country);
            mock.Setup(m => m.ListOfCountries.GetAll()).Returns(list);
            ListOfCountryService service = new ListOfCountryService(mock.Object);

            service.MakeList((listDTO));//JsonSerializer.Serialize

            var listOC = mapper.Map<ListOfCountryDTO, ListOfCountry>(listDTO);
            list.Add(listOC);

            Assert.AreEqual(list.Count(), 5);
        }
        [Test]
        public void EditList_CapableReturned()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountryDTO, ListOfCountry>()).CreateMapper();
            ListOfCountryDTO listDTO = new ListOfCountryDTO() { Id = 3, CountryId = 9, TourId = 7 };
            mock.Setup(m => m.Tours.Get(listDTO.TourId)).Returns(tour);
            mock.Setup(m => m.Countries.Get(listDTO.CountryId)).Returns(country);
            mock.Setup(m => m.ListOfCountries.GetAll()).Returns(list);
            ListOfCountryService service = new ListOfCountryService(mock.Object);

            var listOC = mapper.Map<ListOfCountryDTO, ListOfCountry>(listDTO);

            service.EditListOC((listDTO));//JsonSerializer.Serialize

            mock.Verify(lw => lw.ListOfCountries.Update(It.IsAny<ListOfCountry>()),
    Times.Once());
            Assert.AreNotEqual(listOC, list.Where(p => p.Id == listDTO.Id));
        }

        [Test]
        public void GetListOC_ArrayReturned()
        {
            mock.Setup(m => m.ListOfCountries.GetAll()).Returns(list);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountry, ListOfCountryDTO>()).CreateMapper();
            ListOfCountryService service = new ListOfCountryService(mock.Object);
            //ISerialize<ListOfCountryDTO> serialize = new ListOCSerialize();

            //string[] example = serialize.serializeList(mapper.Map<IEnumerable<ListOfCountry>, List<ListOfCountryDTO>>(list));

            IEnumerable<ListOfCountryDTO> data = service.GetListOC();

            Assert.AreEqual(data.Count(), list.Count());
        }
        [Test]
        public void GetListOCById_ValueReturned()
        {
            mock.Setup(m => m.ListOfCountries.GetAll()).Returns(list);
            mock.Setup(m => m.ListOfCountries.Get(1)).Returns(list.ElementAt(0));
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountry, ListOfCountryDTO>()).CreateMapper();
            ListOfCountryService service = new ListOfCountryService(mock.Object);
            //ISerialize<ListOfCountryDTO> serialize = new ListOCSerialize();

            //string example = serialize.serializeVary(mapper.Map<ListOfCountry, ListOfCountryDTO>(list.ElementAt(0)));

            ListOfCountryDTO data = service.GetListOC(1);

            Assert.IsNotNull(data);
        }
        [Test]
        public void GetListOCByStringId_ValueReturned()
        {
            int i = 1;
            IEnumerable<ListOfCountry> ex;
            ex = new List<ListOfCountry> {
                new ListOfCountry()
                {
                    Id = list.ElementAt(0).Id,
                    CountryId = list.ElementAt(0).CountryId,
                    TourId = list.ElementAt(0).TourId
                }
            };
            mock.Setup(m => m.ListOfCountries.GetAll()).Returns(list);
            mock.Setup(m => m.ListOfCountries.GetName(i.ToString())).Returns(ex);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountry, ListOfCountryDTO>()).CreateMapper();
            ListOfCountryService service = new ListOfCountryService(mock.Object);
            //ISerialize<ListOfCountryDTO> serialize = new ListOCSerialize();

            //string example = serialize.serializeVary(mapper.Map<ListOfCountry, ListOfCountryDTO>(list.ElementAt(0)));

            ListOfCountryDTO data = service.GetListOC(i.ToString());

            Assert.IsNotNull(data);
        }
    }
}
