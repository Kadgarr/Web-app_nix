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
            db.SaveChanges();
        }

        public async Task ChangeAsync(Guid id)
        {
            var item = await db.Genres.FindAsync(id);
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await db.Playlist_of_User.FindAsync(id);
            db.Playlist_of_User.Remove(item);

            await db.SaveChangesAsync();
        }


        public async Task<Playlist_of_User> GetItemAsync(Guid id)
        {
            return await db.Playlist_of_User.FindAsync(id);
        }

        public async Task<IEnumerable<Playlist_of_User>> GetListAsync()
        {
            return await db.Playlist_of_User.ToListAsync();
        }
    }
}
