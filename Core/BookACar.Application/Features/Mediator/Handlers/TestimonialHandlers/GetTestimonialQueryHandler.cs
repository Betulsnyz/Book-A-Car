using BookACar.Application.Features.Mediator.Queries.TestimonialQueries;
using BookACar.Application.Features.Mediator.Results.FeatureResults;
using BookACar.Application.Features.Mediator.Results.TestimonialResults;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var Testimonial = await _repository.GetAllAsync();
            return Testimonial.Select(b => new GetTestimonialQueryResult
            {
                TestimonialID = b.TestimonialID,
                Name = b.Name,
                Comment = b.Comment,
                ImageUrl = b.ImageUrl,
                Title = b.Title

            }).ToList();
        }

    }
}
