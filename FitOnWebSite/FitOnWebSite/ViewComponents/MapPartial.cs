using BusinessLayer.Abstracts;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class MapPartial(IAddressService addressService) : ViewComponent
    {
        //public IViewComponentResult Invoke()
        //{
        //    Context agricultureContext = new Context();
        //    var values = agricultureContext.Addresses.Select(x => x.MapInformation).FirstOrDefault();
        //    ViewBag.m = values;
        //    return View();
        //}

        private readonly IAddressService _addressService = addressService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _addressService.GetListAll();
            return View(values);
        }
    }
}
