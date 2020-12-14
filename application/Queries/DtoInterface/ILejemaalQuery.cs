using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    public interface ILejemaalQuery
    {
        Task<IEnumerable<LejemaalDto>> GetAll();
        Task<LejemaalDto> Get(int LejemaalId);
    }
}
