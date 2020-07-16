using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IUserRepository
    {
        List<User> Users();
        User GetUser(int id);
        List<User> DeleteUser(int id);
        List<User> ActiveUsers();
        List<User> AddUser(User user);
    }
}
