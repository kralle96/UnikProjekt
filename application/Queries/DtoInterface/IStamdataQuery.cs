using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    interface IStamdataQuery
    {
        Task<IEnumerable<StamdataDto>> GetAll();
        Task<SelskabDto> Get(int StamdataId);
    }
}
