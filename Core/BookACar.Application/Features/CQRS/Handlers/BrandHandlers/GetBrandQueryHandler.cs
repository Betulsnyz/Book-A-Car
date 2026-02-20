using BookACar.Application.Features.CQRS.Results.AboutResults;
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
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var brands = await _repository.GetAllAsync();
            return brands.Select(b => new GetBrandQueryResult
            {
                BrandID = b.BrandID,
                Name = b.Name   

            }).ToList();
        }
    } 
}
