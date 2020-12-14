using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    public interface IStatistikLejeperiodeLejersAlderQuery
    {
        Task<IEnumerable<StatistikLejeperiodeLejersAlderDto>> GetAll();
        Task<StatistikLejeperiodeLejersAlderDto> Get(int StatistikLejeperiodeLejersAlderId);
    }
}
