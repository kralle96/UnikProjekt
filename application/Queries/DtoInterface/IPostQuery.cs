using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    public interface IPostQuery
    {
        Task<IEnumerable<PostDto>> GetAll();
        Task<PostDto> Get(int Postnr);
    }
}
