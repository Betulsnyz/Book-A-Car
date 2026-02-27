using Microsoft.AspNetCore.Mvc;

namespace BookACar.WebUI.ViewComponents
{
    public class _BecameADriverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}