using System;
using BLL.Interfaces;
using BLL.DTO;
using UI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using UI_Tour.Json;
using UI_Tour.Json.Deseralization;
using UI_Tour.Json.Interfaces;
using System.Threading.Tasks;
using UI_Tour.Models;
using UI_Tour.Json.Seralization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UI_Tour.Controllers;
using UI_Tour.Control;

namespace UI_Tour.Controllers
{

    public class TourController : Controller
    {
        //ITourService tourService;
        //Helper helper;
        //public static int? TypeId, InfoId, TourId, ListId;
        //public static Tour tourdetails = new Tour();
        //public TourController( ITourService serve)
        //{
        //    tourService = serve;
        //    helper = new Helper(serve);
        //}
        //[Route("Tour/Index")]
        //public ActionResult Index()
        //{
        //    TourAndDetails container = new TourAndDetails();
        //    container.Tours = helper.AllTours();

        //    return View(helper.GetAllInfo(container));
        //}
        //public ActionResult Choose_Type()
        //{
        //    return View(helper.AllTourTypes());
        //}
        //public ActionResult Create(Tour tour)
        //{
        //    ISeralization<Tour> serialize = new TourSerialize();
        //    string data = serialize.serializeVary(tour);

        //    tourService.MakeTour(data);

        //    return RedirectToAction("Index");
        //}
       
        //public ActionResult Choose_Info(int id)
        //{
        //    try
        //    {
        //        TypeId = id;

        //        return View(helper.AllTourInfoes());
        //    }
        //    catch (ValidationException ex)
        //    {
        //        return Content(ex.Message);
        //    }
        //}
        //public ActionResult Choose_Country()
        //{    
        //    IDeseralization<CountryDTO> deseralization = new CountryDeserialize();
        //    IDeseralization<RegionDTO> deseralizationReg = new RegionDeserialize();
        //    IEnumerable<Country> view;
        //    IEnumerable<Region> viewReg;

        //    string[] tours = tourService.GetCountries();// IEnumerator<CountryDTO>
            
        //    IEnumerable<CountryDTO> dto = deseralization.deserializeList(tours);
        //    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CountryDTO, Country>()).CreateMapper();
        //    view = mapper.Map<IEnumerable<CountryDTO>, List<Country>>(dto);

        //    CountryAndRegion container = new CountryAndRegion();
        //    container.Countries = view;

        //    Region[] REG = new Region[view.Count()];
        //    int i = 0;
        //    foreach(Country c in container.Countries)
        //    {
        //        string reg = tourService.GetRegion(c.RegionId);
        //        RegionDTO Regdto = deseralizationReg.deseriallizeVary(reg);

        //        var mapperReg = new MapperConfiguration(cfg => cfg.CreateMap<RegionDTO, Region>()).CreateMapper();
        //        REG[i] = mapperReg.Map<RegionDTO,Region>(Regdto);
                
        //        i++;
        //    }
        //    viewReg = REG;
        //    container.Regions = viewReg;


        //    return View(container);
        //}
        //public ActionResult Add_Tour(int? Id)
        //{
        //    try
        //    {
        //        InfoId = Id;
        //        IDeseralization<TourTypeDTO> deserializeType = new TourTypeDeserialize();
        //        IDeseralization<TourInfoDTO> deserializeInfo = new TourInfoDeserialise();
        //        TourTypeDTO type = deserializeType.deseriallizeVary(tourService.GetTourType(TypeId));
        //        TourInfoDTO info = deserializeInfo.deseriallizeVary(tourService.GetTourInfo(InfoId));

        //        var order = new Tour { TourTypeId = type.Id, InfoId = info.Id }; //+1

        //        return View(order);
        //    }
        //    catch (ValidationException ex)
        //    {
        //        return Content(ex.Message);
        //    }
        //}
            
        //[HttpPost]
        //public ActionResult Add_Tour(Tour order)
        //{
        //    try
        //    {
        //        var orderDto = new Tour { Name = order.Name, InfoId = order.InfoId, TourTypeId = order.TourTypeId };
        //        //tourdetails = new Tour { Id = order.Id, Name = order.Name, InfoId = order.InfoId, TourTypeId = order.TourTypeId };
                
        //        ISeralization<Tour> seralization = new TourSerialize();
        //        tourService.MakeTour(seralization.serializeVary(orderDto));

        //        //TourId = order.Id;

        //        return RedirectToAction("Choose_Country", "Tour");// RedirectToAction("Choose_Country", "Home", new { id = order.Id });
        //    }
        //    catch (ValidationException ex)
        //    {
        //        ModelState.AddModelError("my error with add_tour",ex.Message);
        //    }
        //    return View(order);
        //}

        //public ActionResult Add_ListOC(int? Id)
        //{
        //    try
        //    {
        //        IDeseralization<CountryDTO> deserializeCountry = new CountryDeserialize();
        //        CountryDTO country = deserializeCountry.deseriallizeVary(tourService.GetCountry(Id));

        //        IDeseralization<TourDTO> deserialize = new TourDeserialize();
        //        string[] data = tourService.GetTours();
        //        IEnumerable<TourDTO> listofTours;

        //        listofTours = deserialize.deserializeList(data);
        //        TourDTO info = deserialize.deseriallizeVary(tourService.GetTour(listofTours.Last<TourDTO>().Id));

        //        var order = new ListOfCountry { TourId = info.Id, CountryId = country.Id};

        //        return View(order);
        //    }
        //    catch (ValidationException ex)
        //    {
        //        return Content(ex.Message);
        //    }
        //}
        //[HttpPost]
        //public ActionResult Add_ListOC(ListOfCountry order)
        //{
        //    try
        //    {
        //        var orderDto = new ListOfCountry { TourId = order.TourId,CountryId = order.CountryId };
        //        ISeralization<ListOfCountry> seralization = new ListOCSerialize();
        //        tourService.MakeList(seralization.serializeVary(orderDto));
        //        return RedirectToAction("Index", "Tour"); 
        //    }
        //    catch (ValidationException ex)
        //    {
        //        ModelState.AddModelError("my error with add_tour", ex.Message);
        //    }
        //    return View(order);
        //}
        //public ActionResult EditTour(int? id)
        //{
        //    return RedirectToAction("EditTour", "EditTour", new { id });
        //}
        //protected override void Dispose(bool disposing)
        //{
        //    tourService.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}
