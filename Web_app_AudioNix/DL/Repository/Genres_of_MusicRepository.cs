using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL.Entities;
using DL.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DL.Repository
{
    public class Genres_of_MusicRepository : IRepository<Genres_of_Music>
    {
        ApplicationContext db = new ApplicationContext();


        public void Add(Genres_of_Music item)
        {
            db.Genres_of_Music.Add(item);
        }


        public void Change(Genres_of_Music item)
        {
            db.Attach(item).State = EntityState.Modified;
        }

        public void Delete(Genres_of_Music item)
        {
            db.Genres_of_Music.Remove(item);
        }

        public Genres_of_Music GetItem(Guid item)
        {
            return db.Genres_of_Music.Find(item);
        }

        public IEnumerable<Genres_of_Music> GetList()
        {
            return db.Genres_of_Music.ToList();
        }
    }
}
