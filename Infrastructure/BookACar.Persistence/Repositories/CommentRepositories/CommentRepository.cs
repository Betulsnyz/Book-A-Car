using BookACar.Application.Features.RepositoryPattern;
using BookACar.Domain.Entities;
using BookACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly BookACarContext _context;

        public CommentRepository(BookACarContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(Comment entity)
        {
            var value = _context.Comments.Find(entity.CommentID);
            _context.Comments.Remove(value);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x=> new Comment
            {
                CommentID = x.CommentID,
                Name = x.Name,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                BlogID = x.BlogID
            }).ToList();
        }

        public void Update(Comment entity)
        {
            _context.Comments.Update(entity);
            _context.SaveChanges();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }
    }
}
