using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArchitecture.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
       public ValueTask<T> CreateAsync(T entity);
        public void UpdateAsync(T entity);
        public void DeleteAsync(string EntityId);
        public ValueTask<T> Get(string EntityId);
        public ValueTask<IEnumerable<T>> GetAll();

        int saveChanges();
    }
}
