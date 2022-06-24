using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL.Entities;
using DL.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DL.Repository
{
    public class GenreRepository : IRepository<Genre>
    {
        private ApplicationContext db;
        public GenreRepository(ApplicationContext db)
        {
            this.db = db;
        }
        public void Add(Genre item)
        {
            db.Genres.Add(item);
            db.SaveChanges();
        }

        public void Change(Genre item)
        {
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Genre item)
        {
            db.Genres.Remove(item);
            db.SaveChanges();
        }

        public Genre GetItem(Guid item)
        {
            return db.Genres.Find(item);
        }

        public IEnumerable<Genre> GetList()
        {
            return db.Genres.ToList();
        }
    }
}
