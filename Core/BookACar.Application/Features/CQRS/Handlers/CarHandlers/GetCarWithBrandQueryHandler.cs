using BookACar.Application.Features.CQRS.Results.CarResults;
using BookACar.Application.Interfaces;
using BookACar.Application.Interfaces.CarInterfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var cars =  _repository.GetCarsListWithBrand();
            return cars.Select(c => new GetCarWithBrandQueryResult
            {
                BrandName = c.Brand.Name,
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
