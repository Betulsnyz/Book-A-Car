using BookACar.Application.Features.CQRS.Results.BrandResults;
using BookACar.Application.Features.Mediator.Queries.FeatureQueries;
using BookACar.Application.Features.Mediator.Results.FeatureResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var feature = await _repository.GetByIdAsync(request.Id);
            //Git veritabanına, Id = 5 olan Brand’i bul.

            return new GetFeatureByIdQueryResult
            {
                 FeatureID = feature.FeatureID, 
                 Name = feature.Name
            };
        }
    }
}
