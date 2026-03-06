using BookACar.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookACar.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        //buradan alıp view componente taşıdım

        public IActionResult Index()
        {
            ViewBag.v1= "Hizmetler";
            ViewBag.v2 = "Hizmetlerimiz";
            return View();
        }
    }
}
