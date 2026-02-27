using BookACar.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery :IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
