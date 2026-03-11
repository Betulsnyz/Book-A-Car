using Microsoft.AspNetCore.Mvc;

namespace BookACar.WebUI.ViewComponents.CommentViewComponents
{
    public class _CommentAddComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
