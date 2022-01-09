using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL.Entities;
using DL.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DL.Repository
{
    public class SongsRepository : IRepository<Song>
    {
        ApplicationContext db = new ApplicationContext();

        public void Add(Song item)
        {
            db.Songs.Add(item);
            db.SaveChanges();
        }

        public void Change(Song item)
        {
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Song item)
        {
            db.Songs.Remove(item);
        }

        public Song GetItem(Guid item)
        {
            return db.Songs.Find(item);
        }

        public IEnumerable<Song> GetList()
        {
            return db.Songs.ToList();
        }
    }
}
