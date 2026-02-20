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
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var cars = await _repository.GetAllAsync();
            return cars.Select(c => new GetCarQueryResult
            {
                Model = c.Model,
                BrandID = c.BrandID,
                BigImageUrl = c.BigImageUrl,
                CarID = c.CarID,
                CoverImageUrl = c.CoverImageUrl,
                Fuel = c.Fuel,
                Km = c.Km,
                Luggage = c.Luggage,
                Seat = c.Seat,
                Trasmission = c.Trasmission
            }).ToList();
        }
    }
}
