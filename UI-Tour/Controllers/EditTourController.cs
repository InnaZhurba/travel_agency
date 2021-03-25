using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
//using BLL.Json.Serialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;
using UI_Tour.Control;
using UI_Tour.Json.Deseralization;
using UI_Tour.Json.Interfaces;
using UI_Tour.Json.Seralization;
using UI_Tour.Models;


namespace UI_Tour.Controllers 
{
    public class EditTourController : Controller
    {
        //ITourService tourService;
        //Helper helper;
        //static int ID=0;
        //// GET: EditTour
        //public EditTourController(ITourService serve)
        //{
        //    tourService = serve;
        //    //helper = new Helper(serve);
        //}
        //public ActionResult Index()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult EditTour(Tour order, string Type, string Info, string Country)
        //{
        //    IEnumerable<TourType> view = helper.AllTourTypes();
        //    IEnumerable<TourInfo> info = helper.AllTourInfoes();

        //    foreach(TourType t in view.Where(p => p.Id == Convert.ToInt32(Type)))
        //    {
        //        order.TourTypeId = t.Id;
        //    }
        //    foreach(TourInfo i in info.Where(p => p.Id == Convert.ToInt32(Info)))
        //    {
        //        order.InfoId = i.Id;
        //    }
        //    var orderDto = new Tour {Id = ID, Name = order.Name, InfoId = order.InfoId, TourTypeId = order.TourTypeId };
        //    ISeralization<Tour> seralization = new TourSerialize();
        //    tourService.EditTour(seralization.serializeVary(orderDto));

        //    ListOfCountry listOC = helper.GetListOC(ID);//FindTourByName(order.Name).Id);

        //    string[] word = Country.Split(':');
        //    listOC.CountryId = helper.FindCountryIdByName(word[0], word[1]);

        //    ISeralization<ListOfCountry> seralize = new ListOCSerialize();
        //    tourService.EditListOC(seralize.serializeVary(listOC));

        //    return RedirectToAction("Index", "Tour");
        //}

        //public ActionResult EditTour(int? id)
        //{
        //    ID = Convert.ToInt32(id);
        //    IEnumerable<TourType> view = helper.AllTourTypes();
        //    IEnumerable<TourInfo> info = helper.AllTourInfoes();
        //    IEnumerable<Country> country = helper.AllCountries();
        //    IEnumerable<Region> region = helper.GetRegions(country);
        //    Tour viewTour = helper.GetTour(id);
        //    ListOfCountry listOC = helper.GetListOC(viewTour.Id);

        //    SelectList t = new SelectList(view,"Id" ,"Type", selectedValue: viewTour.TourTypeId);
        //    ViewBag.Types = t;
        //    string type = "";
        //    foreach(TourType h in view.Where(p => p.Id == viewTour.TourTypeId))
        //    {
        //        type += h.Type;
        //    }
        //    ViewBag.Type = type;

        //    SelectList i = new SelectList(info, "Id", "Info", selectedValue: viewTour.InfoId);
        //    ViewBag.Infoes = i;
        //    string inf = "";
        //    foreach (TourInfo h in info.Where(p => p.Id == viewTour.InfoId))
        //    {
        //        inf += h.Info;
        //    }
        //    ViewBag.Info = inf;

        //    List<string> ContriesAndRegions = new List<string>();
        //    foreach(Country h in country)
        //    {
        //        foreach(Region k in region.Where(p => p.Id == h.RegionId))
        //        {
        //            ContriesAndRegions.Add(h.Name + ":" + k.Name);
        //        }
        //    }
        //    SelectList c = new SelectList(ContriesAndRegions, "Country");
        //    ViewBag.Countries = c;
        //    ViewBag.Country = ContriesAndRegions.ElementAt(listOC.CountryId-1);
            
        //    return View(viewTour);
        //}
       
    }
}