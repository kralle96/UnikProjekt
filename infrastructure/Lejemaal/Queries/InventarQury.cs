using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dto;
using Application.Queries.DtoInterface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Lejemaal.Queries
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
