using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HW4Project.Models;

namespace HW4Project.Controllers
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

        [HttpGet]
        public IActionResult RGBColor(RGBResponce rgbResponce)
        {
            if(ModelState.IsValid)
            {
                rgbResponce.HexConverted = "#" + rgbResponce.Red.ToString("X2") + rgbResponce.Green.ToString("X2") + rgbResponce.Blue.ToString("X2");
                return View("RGBColor", rgbResponce);
            }
            else 
            {
                return View("RGBColor", rgbResponce);
            }
            
        }

        // [HttpPost]
        // public IActionResult RGBColor(int? red, int? green, int? blue)
        // {
        //     if(ModelState.IsValid){
        //         string hexValue = "#" + red.ToString("X2") + rgbResponce.Green.ToString("X2") + rgbResponce.Blue.ToString("X2");
        //        // Console.WriteLine(rgbResponce.Red + " " + rgbResponce.Green + " " + rgbResponce.Blue);
        //         return View("RGBColor", rgbResponce);
        //     } else {
        //         return View();
        //     } 
        // }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
