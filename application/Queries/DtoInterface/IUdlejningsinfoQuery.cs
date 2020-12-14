using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    public interface IUdlejningsinfoQuery
    {
        Task<IEnumerable<UdlejningsinfoDto>> GetAll();
        Task<UdlejningsinfoDto> Get(int UdlejningsinfoId);
    }
}
