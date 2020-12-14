﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dto;

namespace Application.Queries.DtoInterface
{
    interface IAnsoegningQuery
    {
        Task<IEnumerable<AnsoegningDto>> GetAll();
        Task<AnsoegningDto> Get(int AnsoegningId);
    }
}
