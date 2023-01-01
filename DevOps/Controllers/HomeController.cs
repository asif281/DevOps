using DevOps.CalculatorService.BMIService;
using DevOps.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace DevOps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBMIService bMIService;
        public HomeController(ILogger<HomeController> logger, IBMIService bMIService)
        {
            _logger = logger;
            this.bMIService = bMIService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMICalculator bMICalculator)
        {
            BMICalculator res = bMIService.CalculateBMI(bMICalculator);
            if (res.Bmi >= 18.5 && res.Bmi <= 24.9)
            {
                ViewBag.TextboxClass = "positive";
            }
            else
            {
                ViewBag.TextboxClass = "negative";
            }
            
            return View(res);
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