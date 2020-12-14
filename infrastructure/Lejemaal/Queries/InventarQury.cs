using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Dto;
using application.Queries.DtoInterface;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Lejemaal.Queries
{
    public class InventarQury : IInventarQuery
    {
        private readonly LejemaalContext _LejemaalContext;

        public InventarQury(LejemaalContext _lejemaalContext)
        {
            _LejemaalContext = _lejemaalContext;
        }

        // Retunere alle Inventar
        async Task<IEnumerable<InventarDto>> IInventarQuery.GetAll()
        {
            return await _LejemaalContext.Inventar.AsNoTracking().Select(a => new InventarDto() { InventarId = a.Id }).ToListAsync();
        }

        // Retunere ejendom fra id
        async Task<InventarDto> IInventarQuery.Get(int inventarId)
        {
            return await _LejemaalContext.Inventar.AsNoTracking().Select(a => new InventarDto() { InventarId = a.Id })
                .FirstOrDefaultAsync(a => a.InventarId == inventarId);
        }
    }
}
