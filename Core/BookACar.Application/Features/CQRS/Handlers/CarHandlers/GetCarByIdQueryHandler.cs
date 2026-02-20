using BookACar.Application.Features.CQRS.Queries.CarQueries;
using BookACar.Application.Features.CQRS.Results.CarResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var car = await _repository.GetByIdAsync(query.Id);
            if (car == null)
                return null;
            return new GetCarByIdQueryResult
            {
                Model = car.Model,
                BrandID = car.BrandID,
                BigImageUrl = car.BigImageUrl,
                CarID = car.CarID,
                CoverImageUrl = car.CoverImageUrl,
                Fuel = car.Fuel,
                Km = car.Km,
                Luggage = car.Luggage,
                Seat = car.Seat,
                Trasmission = car.Trasmission
            };
        }
    }
}
