using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Commands.CommandModel;

namespace application.Commands.CommandInterface
{
    public interface ILejemaalCommand
    {
        // De skal bruges i controlleren i Api´en
        Task Execute(LejemaalCommandModel.CreateLejemaal createLejemaal);
        Task Execute(LejemaalCommandModel.UpdateLejemaal updateLejemaal);
        Task Execute(LejemaalCommandModel.DeleteLejemaal deleteLejemaal);
    }
}
