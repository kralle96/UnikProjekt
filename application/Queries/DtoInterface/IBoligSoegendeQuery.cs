using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    interface IBoligSoegendeQuery
    {
        Task<IEnumerable<BoligSoegendeDto>> GetAll();
        Task<BoligSoegendeDto> Get(int BoligSoegendeId);
    }
}
