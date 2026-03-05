using BookACar.Application.Interfaces.BlogInterfaces;
using BookACar.Domain.Entities;
using BookACar.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BookACarContext _context;

        public BlogRepository(BookACarContext context)
        {
            _context = context;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values = _context.Blogs.Include(x=>x.Author).OrderByDescending(b => b.BlogID).Take(3).ToList();
            return values;
        }
    }
}
