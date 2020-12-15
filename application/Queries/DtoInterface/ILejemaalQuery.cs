using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    public interface ILejemaalQuery
    {
        //Interface til at laese alle lejemaal
        Task<IEnumerable<LejemaalDto>> GetAll();

        //Interface til at lease lejemaal på id
        Task<LejemaalDto> Get(int LejemaalId);
    }
}
