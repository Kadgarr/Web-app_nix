using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DL.IRepository;
using DL.Entities;
namespace DL.Repository
{
    public class Genres_of_MusicRepository : IRepository<Genres_of_Music>
    {
        ApplicationContext db = new ApplicationContext();
        public void Add(Genres_of_Music item)
        {
            throw new NotImplementedException();
        }

        public void Change(Genres_of_Music Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Genres_of_Music item)
        {
            throw new NotImplementedException();
        }

        public Genres_of_Music GetItem(Guid item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genres_of_Music> GetList()
        {
            return db.Genres_of_Music.ToList();
        }
    }
}
