using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    public interface IStatistikLejeperiodeLejersAlderQuery
    {
        Task<IEnumerable<StatistikLejeperiodeLejersAlderDto>> GetAll();
        Task<StatistikLejeperiodeLejersAlderDto> Get(int StatistikLejeperiodeLejersAlderId);
    }
}
