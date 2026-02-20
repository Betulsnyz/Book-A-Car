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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _carRepository;

        public UpdateCarCommandHandler(IRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var car = await _carRepository.GetByIdAsync(command.CarID);
            if (car == null)
                return;
            car.Km = command.Km;
            car.BrandID = command.BrandID;
            car.BigImageUrl = command.BigImageUrl;
            car.CoverImageUrl = command.CoverImageUrl;
            car.Fuel = command.Fuel;
            car.Luggage = command.Luggage;
            car.Model = command.Model;
            car.Seat = command.Seat;
            car.Trasmission = command.Trasmission;
            await _carRepository.UpdateAsync(car);
        }
    }
}
