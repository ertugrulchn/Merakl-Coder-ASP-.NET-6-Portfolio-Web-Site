using Microsoft.AspNetCore.Mvc;

namespace UdemyProject.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
