using Demo_MVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_MVCApp.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            ViewBag.Message = "Sản phẩm truyền từ Controller:";
            var prod = new Product
            {
                ProductId = 1,
                ProductName = "Sản phẩm demo",
                Quatity = 50
            };
            return View(prod);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}