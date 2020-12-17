using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Queries.DtoInterface;
using mvc.Mappers;
using mvc.Models;

namespace mvc.Controllers.Api
{
    //Api til at tilgå queries vedrørende lejemaal

    [ApiController]
    public class LejemaalQueryController : ControllerBase
    {
        public readonly ILejemaalQuery _lejemaalQuery;

        public LejemaalQueryController(ILejemaalQuery lejemaalQuery)
        {
            _lejemaalQuery = lejemaalQuery;
        }

        //Read lejemaal by id
        [HttpGet]
        [Route("Api/GetLejemaalById/{id}")]
        public async Task<IActionResult> GetLejemaalById(int id)
        {
            var lejemaalViewModel = LejemaalMapper.MapGetLejemaalById(await _lejemaalQuery.Get(id));
            return Ok(lejemaalViewModel);
        }

        //Read all lejemaal
        [HttpGet]
        [Route("Api/GetAllLejemaal")]
        public async Task<IActionResult> GetAllLejemaal()
        {
            IEnumerable<LejemaalViewModel> lejemaal = LejemaalMapper.MapGetAllLejemaal(await _lejemaalQuery.GetAll());
            return Ok(lejemaal);
        }
    }
}
