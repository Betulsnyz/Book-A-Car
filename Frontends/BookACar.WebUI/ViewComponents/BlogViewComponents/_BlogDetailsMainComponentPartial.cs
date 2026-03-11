using Microsoft.AspNetCore.Mvc;

namespace BookACar.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsMainComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
