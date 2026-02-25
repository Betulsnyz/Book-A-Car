using Microsoft.AspNetCore.Mvc;

namespace BookACar.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
