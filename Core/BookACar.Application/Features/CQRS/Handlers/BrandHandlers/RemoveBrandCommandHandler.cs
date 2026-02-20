using BookACar.Application.Features.CQRS.Commands.BrandCommands;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;
        public RemoveBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveBrandCommand command)
        {
            var brand = await _repository.GetByIdAsync(command.Id);
            if (brand != null)
            {
                await _repository.RemoveAsync(brand);
            }
        }
    }
}
