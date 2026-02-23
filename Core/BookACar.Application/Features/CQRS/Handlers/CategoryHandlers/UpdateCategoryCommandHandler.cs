using BookACar.Application.Features.CQRS.Commands.CategoryCommands;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCategoryCommand command)
        {
            var Category = await _repository.GetByIdAsync(command.CategoryID);
            if (Category != null)
            {
                Category.Name = command.Name;
                await _repository.UpdateAsync(Category);
            }
        }
    }
}
