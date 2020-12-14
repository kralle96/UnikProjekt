using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    interface IHjemmeboendeBoernQuery
    {
        Task<IEnumerable<HjemmeboendeBoernDto>> GetAll();
        Task<HjemmeboendeBoernDto> Get(int HjemmeboendeBoernId);
    }
}
