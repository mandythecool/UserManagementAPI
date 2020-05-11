using SampleWebApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Model
{
    public interface IUserRepository
    {
        User GetUser(Guid id);
        IEnumerable<User> GetUsers();
        User AddUser(User user);
        User UpdateUser(User user);
        User DeleteUser(Guid id);
            
    }
}
