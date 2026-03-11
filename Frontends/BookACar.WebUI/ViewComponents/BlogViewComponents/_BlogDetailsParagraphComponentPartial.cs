using Microsoft.AspNetCore.Mvc;

namespace BookACar.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsParagraphComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
