using BookACar.Application.Interfaces.CarPricingInterfaces;
using BookACar.Domain.Entities;
using BookACar.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository:ICarPricingRepository
    {
        private readonly BookACarContext _context;

        public CarPricingRepository(BookACarContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(z => z.Pricing).Where(z => z.PricingID == 2).ToList();
            return values;
        }
    }
}
