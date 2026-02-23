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
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var Categorys = await _repository.GetAllAsync();
            return Categorys.Select(b => new GetCategoryQueryResult
            {
                CategoryID = b.CategoryID,
                Name = b.Name

            }).ToList();
        }
    }
}
