using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    public interface ISelskabQuery
    {
        Task<IEnumerable<SelskabDto>> GetAll();
        Task<SelskabDto> Get(int SelskabsId);
    }
}
