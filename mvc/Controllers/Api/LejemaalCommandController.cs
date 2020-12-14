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
    public class LejemaalCommandController : Controller
    {
        public readonly ILejemaalCommand _lejemaalCommand;

        public LejemaalCommandController(ILejemaalCommand lejemaalCommand)
        {
            _lejemaalCommand = lejemaalCommand;
        }

        //Create lejemaal
        [HttpPost]
        [Route("CreateLejemaal")]
        public async void CreateLejemaal(LejemaalViewModel lejemaalViewModel)
        {
            await _lejemaalCommand.Execute(new LejemaalCommandModel.CreateLejemaal { Lejemaal = LejemaalMapper.MapLejemaal(lejemaalViewModel) });
        }

        ////Update lejemaal
        //[HttpPut]
        //[Route("UpdateLejemaal")]
        //public async void UpdateLejemaal(LejemaalViewModel lejemaalViewModel)
        //{
        //    await _lejemaalCommand.Execute(new LejemaalCommandModel.UpdateLejemaal { Lejemaal = LejemaalMapper.MapLejemaal(lejemaalViewModel) });
        //}

        //Delete lejemaal
        [HttpDelete]
        [Route("DeleteLejemaal")]
        public async void DeleteLejemaal(LejemaalViewModel lejemaalViewModel)
        {
            await _lejemaalCommand.Execute(new LejemaalCommandModel.DeleteLejemaal { Lejemaal = LejemaalMapper.MapLejemaal(lejemaalViewModel) });
        }
    }
}
