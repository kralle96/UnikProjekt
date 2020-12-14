using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    interface IBoligSoegendeQuery
    {
        Task<IEnumerable<BoligSoegendeDto>> GetAll();
        Task<BoligSoegendeDto> Get(int BoligSoegendeId);
    }
}
