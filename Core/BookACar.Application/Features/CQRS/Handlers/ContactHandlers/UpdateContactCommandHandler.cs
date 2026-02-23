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
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var Contact = await _repository.GetByIdAsync(command.ContactID);
            Contact.Name = command.Name;
            Contact.Email = command.Email;
            Contact.Message = command.Message;
            Contact.SendDate = command.SendDate;
            Contact.Subject = command.Subject;
            await _repository.UpdateAsync(Contact);
        }
    }
}
