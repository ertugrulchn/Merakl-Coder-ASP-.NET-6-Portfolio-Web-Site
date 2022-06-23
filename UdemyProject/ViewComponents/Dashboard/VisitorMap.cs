using Microsoft.AspNetCore.Mvc;

namespace UdemyProject.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
