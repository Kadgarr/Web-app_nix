using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DL.Entities;
using DL.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DL.Repository
{
    public class UserRepository : IRepository<User>
    {
        private ApplicationContext db;

        public UserRepository(ApplicationContext db)
        {
            this.db = db;
        }
        public void Add(User item)
        {
            db.Users.Add(item);
        }

        public void Change(User item)
        {
            db.Attach(item).State = EntityState.Modified;
        }

        public void Delete(User item)
        {
            db.Users.Remove(item);
        }

        public User GetItem(Guid item)
        {
            return db.Users.Find(item);
        }

        public IEnumerable<User> GetList()
        {
            return db.Users.ToList();
        }
    }
}
