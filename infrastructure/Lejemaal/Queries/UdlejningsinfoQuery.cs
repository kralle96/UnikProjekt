using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Dto;
using application.Queries.DtoInterface;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Lejemaal.Queries
{
    class UdlejningsinfoQuery : IUdlejningsinfoQuery
    {
        private readonly LejemaalContext _LejemaalContext;

        public UdlejningsinfoQuery(LejemaalContext _lejemaalContext)
        {
            _LejemaalContext = _lejemaalContext;
        }

        // Retunere alle udlejningsinformationer
        async Task<IEnumerable<UdlejningsinfoDto>> IUdlejningsinfoQuery.GetAll()
        {
            return await _LejemaalContext.Udlejningsinfo.AsNoTracking().Select(a => new UdlejningsinfoDto { UdlejningsinfoId = a.Id }).ToListAsync();
        }

        // Retunere udlejning fra id
        async Task<UdlejningsinfoDto> IUdlejningsinfoQuery.Get(int udlejningsinfoId)
        {
            return await _LejemaalContext.Udlejningsinfo.AsNoTracking().Select(a => new UdlejningsinfoDto() { UdlejningsinfoId = a.Id })
                .FirstOrDefaultAsync(a => a.UdlejningsinfoId == udlejningsinfoId);
        }
    }
}
