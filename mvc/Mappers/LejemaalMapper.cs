using application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Models;

namespace mvc.Mappers
{
    public class LejemaalMapper
    {
        public static LejemaalViewModel MapGetLejemaalById(LejemaalDto data)
        {
            if (data == null) return null;

            return new LejemaalViewModel
            {
                Adresse = data.Adresse,
                Energimaerke = data.Energimaerke,
                Husdyr = data.Husdyr,
                LejemaalsId = "L" + data.LejemaalsId,
                Ryger = data.Ryger,
                Stoerrelse = data.Stoerrelse,
                Type = data.Type,
                Vaerelser = data.Vaerelser
            };
        }

        public static IEnumerable<LejemaalViewModel> MapGetAllLejemaal(IEnumerable<LejemaalDto> data)
        {
            if (data == null) return null;
            var lejemaalViewModels = new List<LejemaalViewModel>();

            data.ToList().ForEach(lejemaal => lejemaalViewModels.Add(new LejemaalViewModel
            {
                Adresse = lejemaal.Adresse,
                Energimaerke = lejemaal.Energimaerke,
                Husdyr = lejemaal.Husdyr,
                LejemaalsId = "L" + lejemaal.LejemaalsId,
                Ryger = lejemaal.Ryger,
                Stoerrelse = lejemaal.Stoerrelse,
                Type = lejemaal.Type,
                Vaerelser = lejemaal.Vaerelser
            }));
            return lejemaalViewModels;
        }

        public static application.Dto.LejemaalDto MapLejemaal(LejemaalViewModel lejemaalViewModel)
        {
            return new application.Dto.LejemaalDto
            {
                //begynder på index 1, fordi starten af ID'et her vil være L for lejemaal
                LejemaalsId = Convert.ToInt32(lejemaalViewModel.LejemaalsId),
                Adresse = lejemaalViewModel.Adresse,
                Energimaerke = lejemaalViewModel.Energimaerke,
                Husdyr = lejemaalViewModel.Husdyr,
                Ryger = lejemaalViewModel.Ryger,
                Stoerrelse = lejemaalViewModel.Stoerrelse,
                Type = lejemaalViewModel.Type,
                Vaerelser = lejemaalViewModel.Vaerelser
            };
        }
    }
}
