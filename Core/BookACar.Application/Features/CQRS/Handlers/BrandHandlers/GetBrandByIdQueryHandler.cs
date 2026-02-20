using BookACar.Application.Features.CQRS.Queries.BrandQueries;
using BookACar.Application.Features.CQRS.Results.BrandResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var brand = await _repository.GetByIdAsync(query.Id);
            //Git veritabanına, Id = 5 olan Brand’i bul.

            return new GetBrandByIdQueryResult
            {
                BrandID = brand.BrandID,
                Name = brand.Name
            };//Entity'yi direkt dönmüyoruz DTO (Result) oluşturup dönüyoruz

        }
    }
}
