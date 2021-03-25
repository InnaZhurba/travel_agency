using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.DTO;
using BLL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using NUnit.Framework;

namespace BLLTourTestsUnits.Services
{
    [TestFixture]
    public class CountryServiceTest
    {
        Mock<IUnitOfWork> mock = new Mock<IUnitOfWork>();
        List<Country> countries;
        [SetUp]
        public void SetUp()
        {
            countries = new List<Country>
            {
                new Country(){Id=1, Name = "America", RegionId = 3},
                new Country(){Id=2, Name = "Ukraine", RegionId = 2},
                new Country(){Id=3, Name = "Poland", RegionId = 1},
                new Country(){Id=4, Name = "USA", RegionId = 6},
                new Country(){Id=5, Name = "China", RegionId = 8}
            };
        }
        [Test]
        public void GetCountryById_ValueReturned()
        {
            mock.Setup(m => m.Countries.GetAll()).Returns(countries);
            mock.Setup(m => m.Countries.Get(1)).Returns(countries.ElementAt(0));
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Country, CountryDTO>()).CreateMapper();
            CountryService service = new CountryService(mock.Object);
            //ISerialize<CountryDTO> serialize = new CountrySerialize();

            //CountryDTO example = serialize.serializeVary(mapper.Map<Country, CountryDTO>(countries.ElementAt(0)));

            CountryDTO data = service.GetCountry(1);

            Assert.IsNotNull(data);
        }
        [Test]
        public void GetCountries_ArrayReturned()
        {
            mock.Setup(m => m.Countries.GetAll()).Returns(countries);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Country, CountryDTO>()).CreateMapper();
            CountryService service = new CountryService(mock.Object);
            //ISerialize<CountryDTO> serialize = new CountrySerialize();

            //string[] example = serialize.serializeList(mapper.Map<IEnumerable<Country>, List<CountryDTO>>(countries));

            IEnumerable<CountryDTO> data = service.GetCountries();

            Assert.AreEqual(data.Count(), countries.Count());
        }

    }
}
