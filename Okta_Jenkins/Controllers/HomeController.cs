using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Okta_Jenkins.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Okta_Jenkins.Controllers
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
            //add comment for test
            return View();
        }
    }
}
