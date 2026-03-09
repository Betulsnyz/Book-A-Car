using BookACar.Application.Features.Mediator.Queries.CarPricingQueries;
using BookACar.Application.Features.Mediator.Results.CarPricingResults;
using BookACar.Application.Interfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _Repository;

        public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
        {
            _Repository = repository;
        }

        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values=  _Repository.GetCarPricingWithCars();
            return values.Select(x => new GetCarPricingWithCarQueryResult
            {
                CarPricingId = x.CarPricingID,
                Brand = x.Car.Brand.Name,
                Model = x.Car.Model,
                Amount = x.Amount,
                CoverImageUrl = x.Car.CoverImageUrl
            }).ToList();
        }
    }
}
