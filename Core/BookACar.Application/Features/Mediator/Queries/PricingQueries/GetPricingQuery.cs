using BookACar.Application.Features.Mediator.Results.PricingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingQuery :IRequest<GetPricingQueryResult>
    {
    }
}
