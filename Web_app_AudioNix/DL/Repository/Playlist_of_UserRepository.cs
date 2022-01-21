using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL.Entities;
using DL.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DL.Repository
{
    public class Playlist_of_UserRepository : IRepository<Playlist_of_User>
    {
        private ApplicationContext db;

        public Playlist_of_UserRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public void Add(Playlist_of_User item)
        {
            db.Playlist_of_User.Add(item);
        }

        public void Change(Playlist_of_User item)
        {
            db.Attach(item).State = EntityState.Modified;
        }

        public void Delete(Playlist_of_User item)
        {
            db.Playlist_of_User.Remove(item);
        }

        public Playlist_of_User GetItem(Guid item)
        {
            return db.Playlist_of_User.Find(item);
        }

        public IEnumerable<Playlist_of_User> GetList()
        {
            return db.Playlist_of_User.ToList();
        }
    }
}
