using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HW4Project.Models;
using System.Drawing;

namespace HW4Project.Controllers
{
    public class ColorInterpolatorController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            ColorInterpolatorResponse empty = new ColorInterpolatorResponse();
            return View("Create", empty);
            
        }

        [HttpPost]
        public IActionResult Create(ColorInterpolatorResponse colorInterpolatorResponse)
        {
            if(colorInterpolatorResponse.ColorList == null && ModelState.IsValid){
                Debug.WriteLine(colorInterpolatorResponse);
                Debug.WriteLine("Model is OK!");

                List<string> list = new List<string>();
                //for(int i = 0; i <colorInterpolatorResponse.NumberofColors; ++i)
                //{
                    Debug.WriteLine("append");
                    double hue1;
                    double saturation1;
                    double value1;
                    Color color1 = ColorTranslator.FromHtml(colorInterpolatorResponse.FirstColor);
                    ColorInterpolatorResponse.ColorToHSV(color1, out hue1, out saturation1, out value1);

                    double hue2;
                    double saturation2;
                    double value2;
                    Color color2 = ColorTranslator.FromHtml(colorInterpolatorResponse.SecondColor);
                    ColorInterpolatorResponse.ColorToHSV(color2, out hue2, out saturation2, out value2);

                    double hueStep = (hue2 - hue1)/(colorInterpolatorResponse.NumberofColors - 1);
                    double saturationStep = (saturation2 - saturation1)/(colorInterpolatorResponse.NumberofColors - 1);
                    double valueStep = (value2 - value1)/(colorInterpolatorResponse.NumberofColors - 1);

                    //Color colorStep = ColorInterpolatorResponse.ColorFromHSV(hueStep, saturationStep, valueStep);

                    //Debug.WriteLine("hue = " + hue);
                    //Debug.WriteLine("saturation = " + saturation);
                    //Debug.WriteLine("value = " + value);
                    //list.Add(colorInterpolatorResponse.FirstColor);
                    for(int i = 0; i < colorInterpolatorResponse.NumberofColors; i++)
                    {
                        Color colorStep = ColorInterpolatorResponse.ColorFromHSV((hue1 + (i * hueStep)), (saturation1 + (i * saturationStep)), (value1 + (i * valueStep)));
                        list.Add(ColorTranslator.ToHtml(colorStep));
                    }
                    
                //}

                colorInterpolatorResponse.ColorList = list;

                return View("Create", colorInterpolatorResponse);
            }
            else
            {
                //colorInterpolatorResponse.ColorList = null;
                Debug.WriteLine("Model is INVALID!");
                return View("Create", colorInterpolatorResponse);
            }
           
        }

        private readonly ILogger<HomeController> _logger;

        public ColorInterpolatorController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}