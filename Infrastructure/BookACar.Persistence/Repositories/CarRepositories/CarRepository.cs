using BookACar.Application.Interfaces.CarInterfaces;
using BookACar.Domain.Entities;
using BookACar.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly BookACarContext _context;

        public CarRepository(BookACarContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrand()
        {
            var values= _context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
    }
}
