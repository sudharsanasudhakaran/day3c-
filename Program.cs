using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int idValue;
            User user = new User();
            UserRepository repo = new UserRepository();
            Console.WriteLine("Enter the number of users");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("enter id, name, email, location, address, active status");
                user.id = Convert.ToInt32(Console.ReadLine()); ;
                user.Name = Console.ReadLine();
                user.Email = Console.ReadLine();
                user.Location = Console.ReadLine();
                user.Address = Console.ReadLine();
                user.IsActive = true;
                repo.users = repo.AddUser(user);
            }
            Console.WriteLine("enter id value to get user");
            idValue = Convert.ToInt32(Console.ReadLine());
            user = repo.GetUser(idValue);
            repo.users = repo.Users();
            Console.WriteLine("enter id value to Delete user");
            idValue = Convert.ToInt32(Console.ReadLine());
            repo.users = repo.DeleteUser(idValue);
            repo.users = repo.Users();
            for (int i = 0; i < repo.users.Count; i++)
            {
                Console.WriteLine(repo.users[i].id + "\n" + repo.users[i].Name + "\n" + repo.users[i].Email + "\n" + repo.users[i].Location + "\n" + repo.users[i].Address + "\n" + repo.users[i].IsActive);
            }

            Console.WriteLine("Enter User Id");
            int getid = int.Parse(Console.ReadLine());
            User user1 = repo.GetUser(getid);
            if (user1 != null)
            {
                Console.WriteLine("user details are");
                Console.WriteLine(user1.id + "\t" + user1.Name + "\t" + user1.Email + "\t" + user1.Location + "\t" + user1.Address + "\t" + user1.IsActive);

            }
            else
            {
                Console.WriteLine("No users found at the entered position");
            }
            Console.WriteLine("Enter id to find user (active user)");
            List<User> user2 = repo.ActiveUsers();
            Console.WriteLine("Id\t Name\t Email\t Location\t Address\t isActive");
            foreach (var item in user2)
            {
                Console.WriteLine(item.id + "\t" + item.Name + "\t" + item.Email + "\t" + item.Location + "\t" + item.Address + "\t" + item.IsActive);

            }
            Console.WriteLine("delete a user");
            int delId = int.Parse(Console.ReadLine());
            List<User> user3 = repo.DeleteUser(delId);
            Console.WriteLine("Id\t Name\t Email\t Location\t Address\t isActive");
            foreach (var item in user3)
            {
                Console.WriteLine(item.id + "\t" + item.Name + "\t" + item.Email + "\t" + item.Location + "\t" + item.Address + "\t" + item.IsActive);
            }

        }
    }
}
