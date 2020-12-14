using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    public interface IEjendomQuery
    {
        Task<IEnumerable<EjendomDto>> GetAll();
        Task<EjendomDto> Get(int ejendomsId);
    }
}
