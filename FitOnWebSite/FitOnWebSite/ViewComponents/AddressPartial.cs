using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnWebSite.ViewComponents
{
    public class AddressPartial(IAddressService addressService) : ViewComponent
    {
        private readonly IAddressService _addressService = addressService; // Primary Constructor

        public IViewComponentResult Invoke()
        {
            var values = _addressService.GetListAll();
            return View(values);
        }
    }
}
