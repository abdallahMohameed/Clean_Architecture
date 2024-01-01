using cleanArchitecture.Core.Interfaces;
using cleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArchitecture.Infrastructure.Presistence
{
    
    internal class Repository<T> : IRepository<T> where T : class
    {
        private  ApplicationDBContext _context = null;
        private  DbSet<T> _entity;
        public Repository(ApplicationDBContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
        }

        public async ValueTask<T> CreateAsync(T entity)
        {
            await _entity.AddAsync(entity);
            return entity;
        }

        public async void DeleteAsync(string EntityId)
        {
            var data = await _entity.FindAsync(EntityId);
            _entity.Remove(data);
        }

        public async ValueTask<T> Get(string EntityId)
        {
            return await _entity.FindAsync(EntityId);
        }

        public async ValueTask<IEnumerable<T>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public int saveChanges()
        {
            return _context.SaveChanges();
        }

        public void UpdateAsync(T entity)
        {
            _entity.Attach(entity);
        }

    }
}
