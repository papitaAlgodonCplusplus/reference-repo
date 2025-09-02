﻿using AgriSmart.Application.Agronomic.Responses.Queries;
using AgriSmart.Core.Responses;
using MediatR;

namespace AgriSmart.Application.Agronomic.Queries
{
    public record GetCatalogByIdQuery : IRequest<Response<GetCatalogByIdResponse>>
    {
        public int Id { get; set; }
    }
}