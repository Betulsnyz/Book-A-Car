using BookACar.Application.Features.Mediator.Queries.BlogQueries;
using BookACar.Application.Features.Mediator.Results.BlogResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
    {
        private readonly IRepository<Blog> _Repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _Repository = repository;
        }

        public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _Repository.GetAllAsync();
            return values.Select(b => new GetBlogQueryResult
            {
                BlogID = b.BlogID,
                Title = b.Title,
                AuthorID = b.AuthorID,
                CoverImageUrl = b.CoverImageUrl,
                CreatedDate = b.CreatedDate,
                CategoryID = b.CategoryID
            }).ToList();
        }
    }
}
