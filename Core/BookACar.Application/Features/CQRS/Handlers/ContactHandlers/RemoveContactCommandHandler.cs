using BookACar.Application.Features.CQRS.Commands.ContactCommands;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class RemoveContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public RemoveContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveContactCommand command)
        {
            var Contact = await _repository.GetByIdAsync(command.Id);
            if (Contact != null)
            {
                await _repository.RemoveAsync(Contact);
            }
        }
    }
}
