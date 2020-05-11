using SampleWebApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Model
{
    public class SqlUserRepository : IUserRepository
    {
        public SqlUserRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public AppDbContext DbContext { get; }

        public User AddUser(User user)
        {
            DbContext.Users.Add(user);
            DbContext.SaveChanges();
            return user;
        }

        public User DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid id)
        {
            return DbContext.Users.Where(s => s.id == id).SingleOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return DbContext.Users.AsEnumerable();
        }

        public User UpdateUser(User user)
        {
            User u = DbContext.Users.Where(s => s.id == user.id).SingleOrDefault();
            if (u != null)
            {
                u.Age = user.Age;
                u.Name = user.Name;
                DbContext.SaveChanges();
            }
            return u;
        }
    }
}
