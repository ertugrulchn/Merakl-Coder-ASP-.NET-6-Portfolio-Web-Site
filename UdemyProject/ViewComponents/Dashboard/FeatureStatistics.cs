using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UdemyProject.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Where(m => m.Status == false).Count();
            ViewBag.v3 = context.Messages.Where(m => m.Status == true).Count();
            ViewBag.v4 = context.Experiences.Count();
            return View();
        }
    }
}
