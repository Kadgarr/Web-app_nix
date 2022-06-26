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
    public class GenreRepository : IRepository<Genre>
    {
        private ApplicationContext db;
        public GenreRepository(ApplicationContext db)
        {
            this.db = db;
        }
        public void Add(Genre item)
        {
            db.Genres.Add(item);
            db.SaveChanges();
        }

        public async Task ChangeAsync(Guid id)
        {
            var item = await db.Genres.FindAsync(id);
            db.Attach(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item  = await db.Genres.FindAsync(id);
            db.Genres.Remove(item);
           
            await db.SaveChangesAsync();
        }

  
        public async Task<Genre> GetItemAsync(Guid id)
        {
            return await db.Genres.FindAsync(id);
        }

        public async Task<IEnumerable<Genre>> GetListAsync()
        {
            return await db.Genres.ToListAsync();
        }
    }
}
