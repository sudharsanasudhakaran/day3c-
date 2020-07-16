using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserRepository : IUserRepository
    {
        public List<User> users = new List<User>();
        public User GetUser(int id)
        {
            int count = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].id == id)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            return users[count];
        }
        public List<User> DeleteUser(int id)
        {
            int count = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].id == id)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            users.RemoveAt(count);
            return users;
        }
        public List<User> Users()
        {
            return users;
        }
        public List<User> AddUser(User user)
        {
            users.Add(user);
            return users;
        }

        public List<User> ActiveUsers()
        {
            throw new NotImplementedException();
        }
    }
}

