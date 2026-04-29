using Microsoft.AspNetCore.Mvc;

namespace BookACar.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
