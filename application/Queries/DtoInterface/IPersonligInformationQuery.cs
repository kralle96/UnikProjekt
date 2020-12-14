using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    interface IPersonligInformationQuery
    {
        Task<IEnumerable<PersonligInformationDto>> GetAll();
        Task<PersonligInformationDto> Get(int PersonligInformationId);
    }
}
