using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicketTracker.Models;

namespace TicketTracker.Controllers
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
        public IActionResult SimpleDataPage()
        {
            var s = new List<string>();
            s.Add("this is my data");
            s.Add("this is some more data");
            ViewData["myCustomKey"] = "This is my data";
            return View(s);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}