using BookACar.Application.Features.Mediator.Queries.TagCloudQueries;
using BookACar.Application.Features.Mediator.Results.TagCloudResults;
using BookACar.Application.Interfaces.TagCloudInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        private readonly ITagCloudRepository _repository;

        public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetTagCloudByBlogId(request.Id);
            return value.Select(x => new GetTagCloudByBlogIdQueryResult
            {
                BlogID = x.BlogID,
                TagCloudID = x.TagCloudID,
                Title = x.Title
            }).ToList();
        }
    }
}
