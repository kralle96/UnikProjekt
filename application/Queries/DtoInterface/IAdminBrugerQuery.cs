using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    interface IAdminBruger
    {
        Task<IEnumerable<AdminBrugerDto>> GetAll();
        Task<AdminBrugerDto> Get(int AdminBrugerId);
    }
}