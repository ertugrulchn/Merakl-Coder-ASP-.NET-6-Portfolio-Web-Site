using Microsoft.AspNetCore.Mvc;

namespace UdemyProject.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
