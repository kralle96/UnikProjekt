using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    interface IStamdataQuery
    {
        Task<IEnumerable<StamdataDto>> GetAll();
        Task<SelskabDto> Get(int StamdataId);
    }
}
