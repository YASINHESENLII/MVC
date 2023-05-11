using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

    }
}
