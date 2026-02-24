using BookACar.Application.Features.Mediator.Queries.PricingQueries;
using BookACar.Application.Features.Mediator.Results.PricingResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var pricings = await _repository.GetAllAsync();
            return pricings.Select(p => new GetPricingQueryResult
            {
                PricingID = p.PricingID,
                Name = p.Name
            }).ToList();
        }
    }
}
