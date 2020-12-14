using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    public interface IEjendomQuery
    {
        Task<IEnumerable<EjendomDto>> GetAll();
        Task<EjendomDto> Get(int ejendomsId);
    }
}
