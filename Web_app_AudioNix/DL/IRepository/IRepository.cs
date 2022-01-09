using System;
using System.Collections.Generic;
using System.Text;

namespace DL.IRepository
{
    interface IRepository<T> where T:class
    {
        public T GetItem(Guid item);
        public void Add(T item);
        public void Delete(T item);
        public void Change(T item);
        public IEnumerable<T> GetList();
        
    }
}
