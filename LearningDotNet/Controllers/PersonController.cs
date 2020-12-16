using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LearningDotNet.Models;

namespace LearningDotNet.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PersonController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Show()
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
