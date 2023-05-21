using Microsoft.AspNetCore.Mvc;

namespace MyFirstDemoApplicationOnGit.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
