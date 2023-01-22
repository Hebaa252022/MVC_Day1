using Microsoft.AspNetCore.Mvc;

namespace MVC_Day1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("details");
        }
    }
}
