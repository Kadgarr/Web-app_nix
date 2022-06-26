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
    public class AlbumRepository : IRepository<Album>
    {
        private ApplicationContext db;

        public AlbumRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public void Add(Album item)
        {
            db.Albums.Add(item);
            db.SaveChanges();
        }

        public async Task ChangeAsync(Guid id)
        {
            var item = await db.Albums.FindAsync(id);
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await db.Albums.FindAsync(id);
            db.Albums.Remove(item);

            await db.SaveChangesAsync();
        }


        public async Task<Album> GetItemAsync(Guid id)
        {
            return await db.Albums.FindAsync(id);
        }

        public async Task<IEnumerable<Album>> GetListAsync()
        {
            return await db.Albums.ToListAsync();
        }
    }
}
