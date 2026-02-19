using BookACar.Application.Interfaces;
using BookACar.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookACarContext _Context;

        public Repository(BookACarContext context)
        {
            _Context = context;
        }

        public async Task CreateAsync(T entity)
        {
            _Context.Set<T>().Add(entity);
            await _Context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _Context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _Context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _Context.Set<T>().Remove(entity);
            await _Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _Context.Set<T>().Update(entity);
            await _Context.SaveChangesAsync();
        }
    }
}
