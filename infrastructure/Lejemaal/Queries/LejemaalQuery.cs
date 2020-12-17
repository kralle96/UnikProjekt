using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Dto;
using application.Queries.DtoInterface;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Lejemaal.Queries
{
    public class LejemaalQuery : ILejemaalQuery
    {
        public readonly LejemaalContext _LejemaalContext;

        public LejemaalQuery(LejemaalContext _lejemaalContext)
        {
            _LejemaalContext = _lejemaalContext;
        }

        // Retunere alle Lejemål
        async Task<IEnumerable<LejemaalDto>> ILejemaalQuery.GetAll()
        {
            
            return await _LejemaalContext.Lejemaal.AsNoTracking().Select(a => new LejemaalDto
            {
                LejemaalsId = a.Id,
                Adresse = a.Adresse,
                Energimaerke = a.Energimaerke,
                Husdyr = a.Husdyr,
                Ryger = a.Ryger,
                Stoerrelse = a.Stoerrelse,
                Type = a.Type,
                Vaerelser = a.Vaerelser
            }).ToListAsync();
        }

        // Retunere lejemål fra id
        async Task<LejemaalDto> ILejemaalQuery.Get(int lejemaalsId)
        {
            return await _LejemaalContext.Lejemaal.AsNoTracking().Select(a => new LejemaalDto() {
                LejemaalsId = a.Id,
                Adresse = a.Adresse,
                Energimaerke = a.Energimaerke,
                Husdyr = a.Husdyr,
                Ryger = a.Ryger,
                Stoerrelse = a.Stoerrelse,
                Type = a.Type,
                Vaerelser = a.Vaerelser
            }).FirstOrDefaultAsync(a => a.LejemaalsId == lejemaalsId);
        }
    }
}
