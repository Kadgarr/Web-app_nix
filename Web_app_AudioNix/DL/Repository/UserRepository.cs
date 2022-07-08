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

        public async Task ChangeAsync(User user)
        {
            db.Users.Update(user);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var item = await db.Users.FindAsync(id);
            db.Users.Remove(item);

            await db.SaveChangesAsync();
        }

        public async Task<User> GetItemAsync(string name)
        {
            return await db.Users.AsNoTracking().FirstOrDefaultAsync(a => a.UserName == name);
        }

        public async Task<IEnumerable<User>> GetListAsync()
        {
            return await db.Users.ToListAsync();
        }
    }
}
