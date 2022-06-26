using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DL.IRepository
{
    interface IRepository<T> where T:class
    {
        public Task<T> GetItemAsync(Guid id);
        public void Add(T item);
        public Task DeleteAsync(Guid id);
        public Task ChangeAsync(Guid id);
        public Task<IEnumerable<T>> GetListAsync();
        
    }
}
