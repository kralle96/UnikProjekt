using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Queries.DtoInterface;
using mvc.Mappers;
using mvc.Models;

namespace mvc.Controllers.Api
{
    public class LejemaalQueryController : Controller
    {
        public readonly ILejemaalQuery _lejemaalQuery;

        public LejemaalQueryController(ILejemaalQuery lejemaalQuery)
        {
            _lejemaalQuery = lejemaalQuery;
        }

        //Read lejemaal by id
        [HttpGet]
        [Route("GetLejemaalById/{id}")]
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
