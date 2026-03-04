using BookACar.Application.Features.Mediator.Commands.BlogCommands;
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
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _Repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values= await _Repository.GetByIdAsync(request.BlogID);
            values.Title = request.Title;
            values.AuthorID = request.AuthorID;
            values.CoverImageUrl = request.CoverImageUrl;
            values.CreatedDate = request.CreatedDate;
            values.CategoryID = request.CategoryID;
            await _Repository.UpdateAsync(values);
        }
    }
}
