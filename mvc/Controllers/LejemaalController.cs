using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace mvc.Controllers
{
    public class LejemaalController : Controller
    {
        private readonly ILogger<LejemaalController> _logger;

        public LejemaalController(ILogger<LejemaalController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lejemaal()
        {
            return View();
        }

        public IActionResult UpdateLejemaal()
        {
            return View();
        } 
    }
}
