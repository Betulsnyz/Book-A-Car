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
    public class GetLast5CarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetLast5CarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetLast5CarWithBrandQueryResult> Handle()
        {
            var cars =  _repository.GetLast5CarsWithBrands();
            return cars.Select(c => new GetLast5CarWithBrandQueryResult
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
