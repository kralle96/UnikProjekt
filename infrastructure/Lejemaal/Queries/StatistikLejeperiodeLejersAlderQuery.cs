using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Dto;
using application.Queries.DtoInterface;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Lejemaal.Queries
{
    class StatistikLejeperiodeLejersAlderQuery : IStatistikLejeperiodeLejersAlderQuery
    {
        private readonly LejemaalContext _LejemaalContext;

        public StatistikLejeperiodeLejersAlderQuery(LejemaalContext _lejemaalContext)
        {
            _LejemaalContext = _lejemaalContext;
        }

        // Retunere alle Statistiker
        async Task<IEnumerable<StatistikLejeperiodeLejersAlderDto>> IStatistikLejeperiodeLejersAlderQuery.GetAll()
        {
            return await _LejemaalContext.StatistikLejeperiodeLejersAlder.AsNoTracking().Select(a => new StatistikLejeperiodeLejersAlderDto() { StatistikLejerperiodeLejersAlderId = a.Id }).ToListAsync();
        }

        // Retunere statistik fra id
        async Task<StatistikLejeperiodeLejersAlderDto> IStatistikLejeperiodeLejersAlderQuery.Get(int statistikLejerperiodeLejersAlderId)
        {
            return await _LejemaalContext.StatistikLejeperiodeLejersAlder.AsNoTracking().Select(a => new StatistikLejeperiodeLejersAlderDto() { StatistikLejerperiodeLejersAlderId = a.Id })
                .FirstOrDefaultAsync(a => a.StatistikLejerperiodeLejersAlderId == statistikLejerperiodeLejersAlderId);
        }
    }
}
