using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using math.Models;

namespace math.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string view,string cls, string save)
        {

            var Data = new List<Models.ResultDataModel>();
            Models.ResultDataModel result = new Models.ResultDataModel();

            
            if (view == "true")
            {
                
                result.Score = 1.0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.9;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.7;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.55;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.4;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.31;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.45;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.23;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.18;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.15;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0.1;
                Data.Add(result);
            }
            else
            {
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);

                result = new Models.ResultDataModel();
                result.Score = 0;
                Data.Add(result);
            }

            if (cls == "true")
            {

            }

            if (save == "true")
            {

            }

            
            return View(Data);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
