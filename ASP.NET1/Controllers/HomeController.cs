using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Agayev";
            ViewBag.Surname = "Mirsaleh";
            ViewBag.Age = 22;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "+" + 1234567890;
            return View();
        }
    }
}
