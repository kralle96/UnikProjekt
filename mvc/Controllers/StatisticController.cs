using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace mvc .Controllers
{
    public class StatisticController : Controller
    {

        private readonly ILogger<StatisticController> _logger;

        public StatisticController(ILogger<StatisticController> logger)
        {
            _logger = logger;
        }

        public IActionResult StatisticView()
        {
            return View();
        }
    }
}
