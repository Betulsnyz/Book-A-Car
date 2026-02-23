using BookACar.Application.Features.CQRS.Queries.CategoryQueries;
using BookACar.Application.Features.CQRS.Results.CategoryResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var Category = await _repository.GetByIdAsync(query.Id);
            //Git veritabanına, Id = 5 olan Category’i bul.

            return new GetCategoryByIdQueryResult
            {
                CategoryID = Category.CategoryID,
                Name = Category.Name
            };//Entity'yi direkt dönmüyoruz DTO (Result) oluşturup dönüyoruz

        }
    }
}
