using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    public interface IInventarQuery
    {
        Task<IEnumerable<InventarDto>> GetAll();
        Task<InventarDto> Get(int InventarId);
    }
}
