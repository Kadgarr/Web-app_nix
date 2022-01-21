using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL.Entities;
using DL.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DL.Repository
{
    public class PlaylistRepository : IRepository<Playlist>
    {
        private ApplicationContext db;
        public PlaylistRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public void Add(Playlist item)
        {
            db.Playlists.Add(item);
        }

        public void Change(Playlist item)
        {
            db.Attach(item).State = EntityState.Modified;
        }

        public void Delete(Playlist item)
        {
            db.Playlists.Remove(item);
        }

        public Playlist GetItem(Guid item)
        {
            return db.Playlists.Find(item);
        }

        public IEnumerable<Playlist> GetList()
        {
            return db.Playlists.ToList();
        }
    }
}
