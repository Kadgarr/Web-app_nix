using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL.Entities;
using DL.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DL.Repository
{
    public class AlbumRepository : IRepository<Album>
    {
        ApplicationContext db = new ApplicationContext();

        public void Add(Album item)
        {
            db.Albums.Add(item);
            db.SaveChanges();
        }

        public void Change(Album item)
        {
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Album item)
        {
            db.Albums.Remove(item);
        }

        public Album GetItem(Guid item)
        {
            return db.Albums.Find(item);
        }

        public IEnumerable<Album> GetList()
        {
            return db.Albums.ToList();
        }
    }
}
