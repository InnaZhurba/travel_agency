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
    public class TourServicesTest
    {
        Mock<IUnitOfWork> mock = new Mock<IUnitOfWork>();

        List<Tour> tours;
        List<ListOfCountry> list;
        

        TourType type;
        TourInfo info;
        Tour t;
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
            tours = new List<Tour>
            {
                new Tour(){Id = 1, Name="Aqua", TourTypeId = 6, InfoId = 3,},
                new Tour(){Id = 2, Name="Fary", TourTypeId = 5, InfoId = 2,},
                new Tour(){Id = 3, Name="Tommy", TourTypeId = 4, InfoId = 1,},
                new Tour(){Id = 4, Name="Whale", TourTypeId = 3, InfoId = 2,},
                new Tour(){Id = 5, Name="Grid", TourTypeId = 2, InfoId = 3,}
            };
           
            type = new TourType() { Id = 1, Type="Drama"};
            info = new TourInfo() { Id = 2, Info = "Perfect fot you." };
            t = new Tour() { Id = 7, Name = "TourExample", TourTypeId = 4, InfoId = 2 };
            country = new Country() { Id = 4, Name = "USA", RegionId = 4 };
        }

        [Test]
        public void AddTour_CapableAction()
        {
            TourDTO tourDTO = new TourDTO() { Name = "Action", TourTypeId = 1, InfoId = 2 };
            mock.Setup(m => m.Tours.GetAll()).Returns(tours);
            mock.Setup(m => m.TourTypes.Get(tourDTO.TourTypeId)).Returns(type);
            mock.Setup(m => m.TourInfos.Get(tourDTO.InfoId)).Returns(info);
            TourService tourService = new TourService(mock.Object);

            tourService.MakeTour((tourDTO));
           
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourDTO, Tour>()).CreateMapper();
            var tour = mapper.Map<TourDTO,Tour>(tourDTO);
            tours.Add(tour);//tours.Append(tour);

            mock.Verify(lw => lw.Tours.Create(It.IsAny<Tour>()),
    Times.Once());
            Assert.That(tours.Count(), Is.EqualTo(6));
        }

        [Test]
        public void EditTour_CapableAction()
        {
            TourDTO tourDTO = new TourDTO() { Id = 1, Name = "Aq", TourTypeId = 6, InfoId = 3 };
            mock.Setup(m => m.Tours.GetAll()).Returns(tours);
            mock.Setup(m => m.TourTypes.Get(tourDTO.TourTypeId)).Returns(type);
            mock.Setup(m => m.TourInfos.Get(tourDTO.InfoId)).Returns(info);
            TourService tourService = new TourService(mock.Object);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourDTO, Tour>()).CreateMapper();
            var tour = mapper.Map<TourDTO, Tour>(tourDTO);

            tourService.EditTour((tourDTO));//JsonSerializer.Serialize

            mock.Verify(lw => lw.Tours.Update(It.IsAny<Tour>()),
    Times.Once());
            Assert.AreNotEqual(tour, tours.Where(p=>p.Id==tourDTO.Id));
        }      

        [Test]
        public void GetTours_ArrayReturned()
        {
            mock.Setup(m => m.Tours.GetAll()).Returns(tours);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Tour, TourDTO>()).CreateMapper();
            TourService service = new TourService(mock.Object);
            //ISerialize<TourDTO> serialize = new TourSerialize();

            IEnumerable<TourDTO> example = (mapper.Map<IEnumerable<Tour>, List<TourDTO>>(tours));//serialize.serializeList

            IEnumerable<TourDTO> data = service.GetTours();

            Assert.AreEqual(data.Count(), example.Count());
        }
        [Test]
        public void GetTourById_ValueReturned()
        {
            mock.Setup(m => m.Tours.GetAll()).Returns(tours);
            mock.Setup(m => m.Tours.Get(1)).Returns(tours.ElementAt(0));
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Tour, TourDTO>()).CreateMapper();
            TourService service = new TourService(mock.Object);
            //ISerialize<TourDTO> serialize = new TourSerialize();

           //string example = serialize.serializeVary(mapper.Map<Tour, TourDTO>(tours.ElementAt(0)));

            TourDTO data = service.GetTour(1);

            Assert.IsNotNull(data);
        }
       
       
    }
}
