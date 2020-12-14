using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    interface IAdminBruger
    {
        Task<IEnumerable<AdminBrugerDto>> GetAll();
        Task<AdminBrugerDto> Get(int AdminBrugerId);
    }
}