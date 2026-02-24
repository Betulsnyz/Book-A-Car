using BookACar.Application.Features.Mediator.Queries.ServiceQueries;
using BookACar.Application.Features.Mediator.Results.ServiceResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandlers : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandlers(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                ServiceID = value.ServiceID,
                Title = value.Title,
                Description = value.Description,
                IconUrl = value.IconUrl
            };
        }
    }
}
