using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    public interface IInventarQuery
    {
        Task<IEnumerable<InventarDto>> GetAll();
        Task<InventarDto> Get(int InventarId);
    }
}
