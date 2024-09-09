using CLT_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CLT_WebApplication.Controllers
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
        public IActionResult OurServices()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContentMgt()
        {
            return View();
        }
        public IActionResult CorpTrain()
        {
            return View();
        }
        public IActionResult EduTrain()
        {
            return View();
        }
        public IActionResult Mission()
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
