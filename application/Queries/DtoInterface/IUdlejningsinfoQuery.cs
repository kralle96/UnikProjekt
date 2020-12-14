using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    public interface IUdlejningsinfoQuery
    {
        Task<IEnumerable<UdlejningsinfoDto>> GetAll();
        Task<UdlejningsinfoDto> Get(int UdlejningsinfoId);
    }
}
