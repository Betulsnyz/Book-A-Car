using BookACar.Application.Features.CQRS.Queries.ContactQueries;
using BookACar.Application.Features.CQRS.Results.ContactResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var Contact = await _repository.GetByIdAsync(query.Id);
            //Git veritabanına, Id = 5 olan Contact’i bul.
            return new GetContactByIdQueryResult
            {
                ContactID = Contact.ContactID,
                Name = Contact.Name,
                Email = Contact.Email,
                Message = Contact.Message,
                SendDate = Contact.SendDate,
                Subject = Contact.Subject

            };//Entity'yi direkt dönmüyoruz DTO (Result) oluşturup dönüyoruz
        }
    }
}
