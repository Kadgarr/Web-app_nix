using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            db.SaveChanges();
        }

        public async Task ChangeAsync(Guid id)
        {
            var item = await db.Playlists.FindAsync(id);
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await db.Playlists.FindAsync(id);
            db.Playlists.Remove(item);

            await db.SaveChangesAsync();
        }


        public async Task<Playlist> GetItemAsync(Guid id)
        {
            return await db.Playlists.FindAsync(id);
        }

        public async Task<IEnumerable<Playlist>> GetListAsync()
        {
            return await db.Playlists.ToListAsync();
        }
    }
}
