using BookACar.Application.Interfaces.TagCloudInterfaces;
using BookACar.Domain.Entities;
using BookACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly BookACarContext _context;

        public TagCloudRepository(BookACarContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudByBlogId(int id)
        {
            var values= _context.TagClouds.Where(x => x.BlogID == id).ToList(); 
            return values;
        }
    }
}
