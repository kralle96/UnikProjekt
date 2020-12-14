using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    interface IHjemmeboendeBoernQuery
    {
        Task<IEnumerable<HjemmeboendeBoernDto>> GetAll();
        Task<HjemmeboendeBoernDto> Get(int HjemmeboendeBoernId);
    }
}
