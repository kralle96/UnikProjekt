using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    public interface ISelskabQuery
    {
        Task<IEnumerable<SelskabDto>> GetAll();
        Task<SelskabDto> Get(int SelskabsId);
    }
}
