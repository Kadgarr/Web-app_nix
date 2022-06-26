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
    public class SongRepository : IRepository<Song>
    {
        private ApplicationContext db;
        public SongRepository(ApplicationContext db)
        {
            this.db = db;
        }
        
        public void Add(Song item)
        {
            db.Songs.Add(item);
            db.SaveChanges();
        }

        public async Task ChangeAsync(Guid id)
        {
            var item = await db.Songs.FindAsync(id);
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await db.Songs.FindAsync(id);
            db.Songs.Remove(item);

            await db.SaveChangesAsync();
        }


        public async Task<Song> GetItemAsync(Guid id)
        {
            return await db.Songs.FindAsync(id);
        }

        public async Task<IEnumerable<Song>> GetListAsync()
        {
            return await db.Songs.ToListAsync();
        }
    }
}
