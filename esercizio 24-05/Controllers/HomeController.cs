using esercizio_24_05.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace esercizio_24_05.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
             var menu = new List<MenuModel>()
            {
                new MenuModel { Name = "Coca Cola 150 ml ", Price = 2.50 },
                new MenuModel { Name = "Insalata di pollo ", Price =  5.20},
                new MenuModel { Name = "Pizza Margherita", Price =  10.00},
            };
            return View(menu);
        }
 
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
