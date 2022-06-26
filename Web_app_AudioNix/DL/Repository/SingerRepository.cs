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
    public class SingerRepository : IRepository<Singer>
    {
        private ApplicationContext db;
        public SingerRepository(ApplicationContext db)
        {
            this.db = db;
        }
        public void Add(Singer item)
        {
            db.Singers.Add(item);
            db.SaveChanges();
        }

        public async Task ChangeAsync(Guid id)
        {
            var item = await db.Singers.FindAsync(id);
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await db.Singers.FindAsync(id);
            db.Singers.Remove(item);

            await db.SaveChangesAsync();
        }


        public async Task<Singer> GetItemAsync(Guid id)
        {
            return await db.Singers.FindAsync(id);
        }

        public async Task<IEnumerable<Singer>> GetListAsync()
        {
            return await db.Singers.ToListAsync();
        }
    }
}
