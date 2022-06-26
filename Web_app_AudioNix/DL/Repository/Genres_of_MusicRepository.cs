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
    public class Genres_of_MusicRepository : IRepository<Genres_of_Music>
    {
        private ApplicationContext db;

        public Genres_of_MusicRepository(ApplicationContext db)
        {
            this.db = db;
        }


        public void Add(Genres_of_Music item)
        {
            db.Genres_of_Music.Add(item);
            db.SaveChanges();
        }

        public async Task ChangeAsync(Guid id)
        {
            var item = await db.Genres_of_Music.FindAsync(id);
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await db.Genres_of_Music.FindAsync(id);
            db.Genres_of_Music.Remove(item);

            await db.SaveChangesAsync();
        }


        public async Task<Genres_of_Music> GetItemAsync(Guid id)
        {
            return await db.Genres_of_Music.FindAsync(id);
        }

        public async Task<IEnumerable<Genres_of_Music>> GetListAsync()
        {
            return await db.Genres_of_Music.ToListAsync();
        }
    }
}
