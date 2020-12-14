using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    public interface ILejemaalQuery
    {
        Task<IEnumerable<LejemaalDto>> GetAll();
        Task<LejemaalDto> Get(int LejemaalId);
    }
}
