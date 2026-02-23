using BookACar.Application.Features.CQRS.Results.BrandResults;
using BookACar.Application.Features.Mediator.Queries.FeatureQueries;
using BookACar.Application.Features.Mediator.Results.FeatureResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
            var feature = await _repository.GetAllAsync();
            return feature.Select(b => new GetFeatureQueryResult
            {
                FeatureID = b.FeatureID,
                Name = b.Name

            }).ToList();
        }
    }
}
