using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Dto;
using application.Queries.DtoInterface;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Lejemaal.Queries
{
    public class SelskabQuery : ISelskabQuery
    {
        private readonly LejemaalContext _LejemaalContext;

        public SelskabQuery(LejemaalContext _lejemaalContext)
        {
            _LejemaalContext = _lejemaalContext;
        }

        // Retunere alle selskaber
        async Task<IEnumerable<SelskabDto>> ISelskabQuery.GetAll()
        {
            return await _LejemaalContext.Selskab.AsNoTracking().Select(a => new SelskabDto { SelskabsId = a.Id }).ToListAsync();
        }

        // Retunere selskab fra id
        async Task<SelskabDto> ISelskabQuery.Get(int selskabsId)
        {
            return await _LejemaalContext.Selskab.AsNoTracking().Select(a => new SelskabDto() { SelskabsId = a.Id })
                .FirstOrDefaultAsync(a => a.SelskabsId == selskabsId);
        }
    }
}
