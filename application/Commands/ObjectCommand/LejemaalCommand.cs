using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Commands.CommandInterface;
using application.Commands.CommandModel;
using application.Commands.Repository;
using application.Queries.DtoInterface;

namespace application.Commands.ObjectCommand
{
    // Bruges til Infrastructure niveau
    public class LejemaalCommand : ILejemaalCommand
    {
        //dependency injection
        private readonly ILejemaalRepository _lejemaalRepository;

        public LejemaalCommand(ILejemaalRepository lejemaalRepository)
        {
            _lejemaalRepository = lejemaalRepository;
        }

        //Giver data fra LejemaalDto til Lejemaal i domænet
        async Task ILejemaalCommand.Execute(LejemaalCommandModel.CreateLejemaal createLejemaal)
        {
            var lejemaal = new domain.Model.Lejemaal()
            {
                //begynder på index 1, fordi starten af ID'et her vil være L for lejemaal
                Adresse = createLejemaal.Lejemaal.Adresse,
                Energimaerke = createLejemaal.Lejemaal.Energimaerke,
                Husdyr = createLejemaal.Lejemaal.Husdyr,
                Ryger = createLejemaal.Lejemaal.Ryger,
                Stoerrelse = createLejemaal.Lejemaal.Stoerrelse,
                Type = createLejemaal.Lejemaal.Type,
                Vaerelser = createLejemaal.Lejemaal.Vaerelser
            }; ;
            await _lejemaalRepository.Save(lejemaal);
        }


        async Task ILejemaalCommand.Execute(LejemaalCommandModel.UpdateLejemaal updateLejemaal)
        {
            //var lejemaal = await _lejemaalRepository.Load(updateLejemaal.Lejemaal.LejemaalsId);
            //await _lejemaalRepository.Update(lejemaal);

            //awit _lejemaalRepository.Update(updateLejemaal)

            var updatedLejemaal = new domain.Model.Lejemaal()
            {
                Id = updateLejemaal.Lejemaal.LejemaalsId,
                Adresse = updateLejemaal.Lejemaal.Adresse,
                Energimaerke = updateLejemaal.Lejemaal.Energimaerke,
                Husdyr = updateLejemaal.Lejemaal.Husdyr,
                Ryger = updateLejemaal.Lejemaal.Ryger,
                Stoerrelse = updateLejemaal.Lejemaal.Stoerrelse,
                Type = updateLejemaal.Lejemaal.Type,
                Vaerelser = updateLejemaal.Lejemaal.Vaerelser
            };

            await _lejemaalRepository.Update(updatedLejemaal);
        }

        async Task ILejemaalCommand.Execute(LejemaalCommandModel.DeleteLejemaal deleteLejemaal)
        {
            var lejemaal = await _lejemaalRepository.Load(deleteLejemaal.Lejemaal.LejemaalsId);
            await _lejemaalRepository.Delete(lejemaal);
        }
    }
}
