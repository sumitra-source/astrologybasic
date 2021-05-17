using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using astrobasic.Models;

namespace astrobasic.Controllers
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
         public IActionResult SevenChakrasPage()
        {
            return View();
        }
         public IActionResult NorthnodesouthnodeDescription()
        {
            return View();
        }
       
        public IActionResult LifePathnumber()
        {
            return View();

        }
          public IActionResult PersonalYearnumber()
        {
            return View();

        }
        
        public IActionResult WesternAstrology()
        {
            return View();

        }
        
        public IActionResult VedicAstrology()
        {
            return View();

        }

        public IActionResult TarotcardBasic()
        {
            return View();
        }
        public IActionResult RisingmoonsunSign()
        {
            return View();
        }
        public IActionResult NumerologyDetail()
        {
            return View();

        }
        public IActionResult HousesInformation()
        {
            return View();
        }
        public IActionResult BirthchartDetail()
        {
            return View();
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
