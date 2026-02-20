using BookACar.Application.Features.CQRS.Commands.CarCommands;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _carRepository;

        public CreateCarCommandHandler(IRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            Car car = new Car
            {
                Km = command.Km,
                BrandID = command.BrandID,
                BigImageUrl = command.BigImageUrl,
                CoverImageUrl = command.CoverImageUrl,
                Fuel = command.Fuel,
                Luggage = command.Luggage,
                Model = command.Model,
                Seat = command.Seat,    
                
                Trasmission = command.Trasmission
            };
            await _carRepository.CreateAsync(car);
        }
    }
}
