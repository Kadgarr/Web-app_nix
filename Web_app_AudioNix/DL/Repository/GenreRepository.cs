using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL.Entities;
using DL.IRepository;

namespace DL.Repository
{
    public class GenreRepository:IRepository<Genre>
    {
        ApplicationContext db = new ApplicationContext();

        public void Add(Genre item)
        {
            throw new NotImplementedException();
        }

        public void Change(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Genre item)
        {
            throw new NotImplementedException();
        }

        public Genre GetItem(Guid item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetList()
        {
            return db.Genres.ToList();
        }
    }
}
