using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnikUdlejning.Models;
using Microsoft.Extensions.Logging;

namespace UnikUdlejning.Controllers
{
    public class BoligController : Controller
    {
        private readonly ILogger<BoligController> _logger;

        public BoligController(ILogger<BoligController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FindBolig()
        {
            return View();
        }

    }
}
