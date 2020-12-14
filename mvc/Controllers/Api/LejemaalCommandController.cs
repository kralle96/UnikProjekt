using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Commands.CommandInterface;
using application.Commands.CommandModel;
using mvc.Mappers;
using mvc.Models;

namespace mvc.Controllers.Api
{
    [ApiController]
    public class LejemaalCommandController : ControllerBase
    {
        public readonly ILejemaalCommand _lejemaalCommand;

        public LejemaalCommandController(ILejemaalCommand lejemaalCommand)
        {
            _lejemaalCommand = lejemaalCommand;
        }

        //Create lejemaal
        [HttpPost]
        [Route("Api/CreateLejemaal")]
        public async Task<IActionResult> CreateLejemaal(LejemaalViewModel lejemaalViewModel)
        {
            await _lejemaalCommand.Execute(new LejemaalCommandModel.CreateLejemaal { Lejemaal = LejemaalMapper.MapLejemaal(lejemaalViewModel) });
            return Ok("");
        }

        //Update lejemaal
        [HttpPut]
        [Route("Api/UpdateLejemaal")]
        public async Task<IActionResult> UpdateLejemaal(LejemaalViewModel lejemaalViewModel)
        {
            await _lejemaalCommand.Execute(new LejemaalCommandModel.UpdateLejemaal { Lejemaal = LejemaalMapper.MapLejemaal(lejemaalViewModel) });
            return Ok("");
        }

        //Delete lejemaal
        [HttpDelete]
        [Route("Api/DeleteLejemaal")]
        public async Task<IActionResult> DeleteLejemaal(LejemaalViewModel lejemaalViewModel)
        {
            await _lejemaalCommand.Execute(new LejemaalCommandModel.DeleteLejemaal { Lejemaal = LejemaalMapper.MapLejemaal(lejemaalViewModel) });
            return Ok("");
        }
    }
}
