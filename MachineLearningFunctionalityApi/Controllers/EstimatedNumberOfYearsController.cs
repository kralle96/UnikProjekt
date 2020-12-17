using application.Services.Machine_Learning;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineLearningFunctionalityApi.Controllers
{
    //api til at benytte vores machine learning modeller

    [ApiController]
    public class EstimatedNumberOfYearsController : Controller
    {

        [Route("EstimatedNumberOfYears")]
        [HttpGet]
        public IActionResult Index(string koen, int antalBeboereILejemaal, int antalVaerelser, string lejemaalType,
            string region, int ansoegerAlder)
        {
            //bør blive dependency injected... Følger ikke SOLID

            NumberOfYearsPredictionPython estimation = new NumberOfYearsPredictionPython(koen, antalBeboereILejemaal,
                antalVaerelser, lejemaalType, region, ansoegerAlder);
            CPythonBinder binder = new CPythonBinder();
            string result = binder.MakePrediction(estimation.Script, estimation.ScriptPath, estimation.Parameters);
            result = result.Substring(0, 4);

            return Ok(result);
        }
    }
}
