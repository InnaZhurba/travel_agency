using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UI.Models;
using UI_Tour.Json.Deseralization;
using UI_Tour.Json.Interfaces;
using UI_Tour.Models;

namespace UI_Tour.Control
{
    public class Helper
    {
        //public int FindCountryIdByName(string name, string regionName)
        //{
        //    int id = 0;
        //    IEnumerable<Country> country = AllCountries();
        //    Region[] region = GetRegions(country);
        //    foreach (Country c in country.Where(p => p.Name == name))
        //    {
        //        if (region[c.Id - 1].Name == regionName)
        //            id = c.Id;
        //    }
        //    return id;
        //}
        //public Tour FindTourByName(string name)
        //{
        //    IEnumerable<Tour> view = AllTours();
        //    Tour tour = new Tour();
        //    foreach (Tour t in view.Where(p => p.Name == name))
        //    {
        //        tour = t;
        //    }
        //    return tour;
        //}
        //public Region[] GetRegions(IEnumerable<Country> country)
        //{
        //    Region[] data = new Region[country.Count()];
        //    int i = 0;
        //    foreach (Country c in country)
        //    {
        //        data[i] = GetRegion(c.RegionId);
        //        i++;
        //    }
        //    return data;
        //}
        //public Tour GetTour(int? id)
        //{
        //    IDeseralization<TourDTO> deseralizationTour = new TourDeserialize();
        //    string tours = tourService.GetTour(id);
        //    TourDTO Tourdto = deseralizationTour.deseriallizeVary(tours);
        //    var Tourmapper = new MapperConfiguration(cfg => cfg.CreateMap<TourDTO, Tour>()).CreateMapper();

        //    return Tourmapper.Map<TourDTO, Tour>(Tourdto);
        //}
        //public ListOfCountry GetListOC(int? id)
        //{
        //    IDeseralization<ListOfCountryDTO> deseralization = new ListOCDeseralisation();
        //    string data = tourService.GetListOC(id.ToString());
        //    ListOfCountryDTO dto = deseralization.deseriallizeVary(data);
        //    var Tourmapper = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountryDTO, ListOfCountry>()).CreateMapper();

        //    return Tourmapper.Map<ListOfCountryDTO, ListOfCountry>(dto);
        //}
        //public IEnumerable<Tour> AllTours()
        //{
        //    IDeseralization<TourDTO> deseralization = new TourDeserialize();

        //    string[] types = tourService.GetTours();// IEnumerator<CountryDTO>
        //    IEnumerable<TourDTO> dto = deseralization.deserializeList(types);
        //    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourDTO, Tour>()).CreateMapper();

        //    return mapper.Map<IEnumerable<TourDTO>, List<Tour>>(dto);
        //}
        //public IEnumerable<TourType> AllTourTypes()
        //{
        //    IDeseralization<TourTypeDTO> deseralization = new TourTypeDeserialize();

        //    string[] types = tourService.GetTourTypes();// IEnumerator<CountryDTO>
        //    IEnumerable<TourTypeDTO> Typedto = deseralization.deserializeList(types);
        //    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourTypeDTO, TourType>()).CreateMapper();

        //    return mapper.Map<IEnumerable<TourTypeDTO>, List<TourType>>(Typedto);
        //}
        //public IEnumerable<TourInfo> AllTourInfoes()
        //{
        //    IDeseralization<TourInfoDTO> deseralization = new TourInfoDeserialise();

        //    string[] data = tourService.GetTourInfos();
        //    IEnumerable<TourInfoDTO> dto = deseralization.deserializeList(data);
        //    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TourInfoDTO, TourInfo>()).CreateMapper();

        //    return mapper.Map<IEnumerable<TourInfoDTO>, List<TourInfo>>(dto);
        //}
        //public IEnumerable<Country> AllCountries()
        //{
        //    IDeseralization<CountryDTO> deseralization = new CountryDeserialize();

        //    string[] data = tourService.GetCountries();
        //    IEnumerable<CountryDTO> dto = deseralization.deserializeList(data);
        //    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CountryDTO, Country>()).CreateMapper();

        //    return mapper.Map<IEnumerable<CountryDTO>, List<Country>>(dto);
        //}
        //public Region GetRegion(int? id)
        //{
        //    IDeseralization<RegionDTO> deseralization = new RegionDeserialize();

        //    string data = tourService.GetRegion(id);
        //    RegionDTO dto = deseralization.deseriallizeVary(data);
        //    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<RegionDTO, Region>()).CreateMapper();

        //    return mapper.Map<RegionDTO, Region>(dto);
        //}
        //public string[] GetAllInfo(TourAndDetails container)
        //{
        //    container.Types = typeShow(container);
        //    container.Infos = infoShow(container);           
        //    container.ListOfCountries = listShow(container);
        //    container.Countries = countryShow(container);
        //    container.Regions = regionShow(container);            

        //    return allInfo(container);
        //    //return container;
        //}
        //public TourType[] typeShow(TourAndDetails container)
        //{
        //    IDeseralization<TourTypeDTO> deseralization = new TourTypeDeserialize();
        //    TourType[] REG = new TourType[container.Tours.Count()];

        //    int i = 0;
        //    foreach (Tour c in container.Tours)
        //    {
        //        string reg = tourService.GetTourType(c.TourTypeId);
        //        TourTypeDTO Regdto = deseralization.deseriallizeVary(reg);
        //        var mapperReg = new MapperConfiguration(cfg => cfg.CreateMap<TourTypeDTO, TourType>()).CreateMapper();
        //        REG[i] = mapperReg.Map<TourTypeDTO, TourType>(Regdto);
        //        i++;
        //    }
        //    return REG;
        //}
        //public TourInfo[] infoShow(TourAndDetails container)
        //{
        //    IDeseralization<TourInfoDTO> deseralizationReg = new TourInfoDeserialise();
        //    TourInfo[] info = new TourInfo[container.Tours.Count()];

        //    int i = 0;
        //    foreach (Tour c in container.Tours)
        //    {

        //        string det = tourService.GetTourInfo(c.InfoId);
        //        TourInfoDTO Infodto = deseralizationReg.deseriallizeVary(det);
        //        var mapperInfo = new MapperConfiguration(cfg => cfg.CreateMap<TourInfoDTO, TourInfo>()).CreateMapper();
        //        info[i] = mapperInfo.Map<TourInfoDTO, TourInfo>(Infodto);
        //        i++;
        //    }
        //    return info;
        //}
        //public ListOfCountry[] listShow(TourAndDetails container)
        //{
        //    IDeseralization<ListOfCountryDTO> deseralizationListOC = new ListOCDeseralisation();
        //    ListOfCountry[] list = new ListOfCountry[container.Tours.Count()];

        //    int i = 0;
        //    foreach (Tour c in container.Tours)
        //    {

        //        string cou = tourService.GetListOC(c.Id.ToString());
        //        ListOfCountryDTO coun = deseralizationListOC.deseriallizeVary(cou);
        //        var mapperListOC = new MapperConfiguration(cfg => cfg.CreateMap<ListOfCountryDTO, ListOfCountry>()).CreateMapper();
        //        list[i] = mapperListOC.Map<ListOfCountryDTO, ListOfCountry>(coun);
        //        i++;
        //    }
        //    return list;
        //}
        //public Country[] countryShow(TourAndDetails container)
        //{
        //    IDeseralization<CountryDTO> deseralizationCountry = new CountryDeserialize();
        //    Country[] country = new Country[container.Tours.Count()];

        //    int i = 0;
        //    foreach (ListOfCountry c in container.ListOfCountries)
        //    {
        //        string count = tourService.GetCountry(c.CountryId);//list[i].CountryId)
        //        CountryDTO Cou = deseralizationCountry.deseriallizeVary(count);
        //        var mapperCountry = new MapperConfiguration(cfg => cfg.CreateMap<CountryDTO, Country>()).CreateMapper();
        //        country[i] = mapperCountry.Map<CountryDTO, Country>(Cou);
        //        i++;
        //    }
        //    return country;
        //}
        //public Region[] regionShow(TourAndDetails container)
        //{
        //    IDeseralization<RegionDTO> deseralizationRegion = new RegionDeserialize();
        //    Region[] region = new Region[container.Tours.Count()];

        //    int i = 0;
        //    foreach (Country c in container.Countries)
        //    {
        //        string regi = tourService.GetRegion(c.RegionId);//country[i].RegionId
        //        RegionDTO Regi = deseralizationRegion.deseriallizeVary(regi);
        //        var mapperRegion = new MapperConfiguration(cfg => cfg.CreateMap<RegionDTO, Region>()).CreateMapper();
        //        region[i] = mapperRegion.Map<RegionDTO, Region>(Regi);

        //        i++;
        //    }
        //    return region;
        //}
        //public string[] allInfo(TourAndDetails container)
        //{
        //    string[] data = new string[container.Tours.Count()];
        //    string i="", j="", k="", n="";
        //    int a = 0, b = 0, h = 0;
        //    foreach(var item in container.Tours)
        //    {
        //      foreach(var val in container.Types.Where(p => p.Id == item.TourTypeId)) { i = val.Type; }
        //      foreach(var val in container.Infos.Where(p => p.Id == item.InfoId)) { j = val.Info; }
        //      foreach(var val in container.ListOfCountries.Where(p => p.TourId == item.Id)) { a = val.CountryId; }
        //      foreach(var val in container.Countries.Where(p => p.Id == a)) { k = val.Name; b = val.RegionId; }
        //      foreach(var val in container.Regions.Where(p => p.Id == b)) { n = val.Name; }

        //        data[h] = item.Id + ". " + item.Name + " - " + i + " - " + j + " - " + k + " - " + n + ";";
        //        h++;
        //    }
        //    return data;
        //}
    }
}