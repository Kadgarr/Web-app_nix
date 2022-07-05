using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Entities;
using DL.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DL.Repository
{
    public class UserRepository //: IRepository<User>
    {
        private ApplicationContext db;

        public UserRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public void Add(User item)
        {
            db.Users.Add(item);
            db.SaveChanges();
        }

        public async Task ChangeAsync(Guid id)
        {
            var item = await db.Users.FindAsync(id);
            db.Attach(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await db.Users.FindAsync(id);
            db.Users.Remove(item);

            await db.SaveChangesAsync();
        }

        public Task<User> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetListAsync()
        {
            return await db.Users.ToListAsync();
        }
    }
}
