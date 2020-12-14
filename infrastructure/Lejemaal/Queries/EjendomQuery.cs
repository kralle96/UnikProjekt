using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Dto;
using application.Queries.DtoInterface;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Lejemaal.Queries
{
    public class EjendomQuery : IEjendomQuery
    {
        private readonly LejemaalContext _LejemaalContext;

        public EjendomQuery(LejemaalContext _lejemaalContext)
        {
            _LejemaalContext = _lejemaalContext;
        }

        // Retunere alle ejendomme
        async Task<IEnumerable<EjendomDto>> IEjendomQuery.GetAll()
        {
            return await _LejemaalContext.Ejendom.AsNoTracking().Select(a => new EjendomDto { EjendomsId = a.Id }).ToListAsync();
        }
        
        // Retunere ejendom fra id
        async Task<EjendomDto> IEjendomQuery.Get(int ejendomsId)
        {
            return await _LejemaalContext.Ejendom.AsNoTracking().Select(a => new EjendomDto {EjendomsId = a.Id})
                .FirstOrDefaultAsync(a => a.EjendomsId == ejendomsId);
        }
    }
}
