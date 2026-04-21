using Microsoft.AspNetCore.Mvc;

namespace BookACar.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
