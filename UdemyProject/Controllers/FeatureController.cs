using Microsoft.AspNetCore.Mvc;

namespace UdemyProject.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
