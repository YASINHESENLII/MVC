using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class ShopContreller : Controller
    {
        public IActionResult Index()
        {
            return View("Shop");
        }
        public IActionResult Details()
        {
            return View("singleproduct");
        }

    }
}
