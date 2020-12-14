using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    interface IAnsoegningQuery
    {
        Task<IEnumerable<AnsoegningDto>> GetAll();
        Task<AnsoegningDto> Get(int AnsoegningId);
    }
}
