﻿using System.Collections.Generic;
using System.Threading.Tasks;
using application.Dto;

namespace application.Queries.DtoInterface
{
    interface IPersonligInformationQuery
    {
        Task<IEnumerable<PersonligInformationDto>> GetAll();
        Task<PersonligInformationDto> Get(int PersonligInformationId);
    }
}
