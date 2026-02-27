using BookACar.Application.Features.Mediator.Queries.LocationQueries;
using BookACar.Application.Features.Mediator.Results.FeatureResults;
using BookACar.Application.Features.Mediator.Results.LocationResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;

        public GetLocationQueryHandler(IRepository<Location>repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var location = await _repository.GetAllAsync();
            return location.Select(b => new GetLocationQueryResult
            {
                LocationID = b.LocationID,
                Name = b.Name
                

            }).ToList();
        }

    }
}
