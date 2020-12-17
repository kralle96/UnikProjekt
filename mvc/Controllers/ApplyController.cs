using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;


namespace mvc.Controllers
{
    public class ApplyController : Controller
    {

        private readonly ILogger<ApplyController> _logger;

        public ApplyController(ILogger<ApplyController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ApplyLejemaal()
        {
            return View();
        }

    }
}
