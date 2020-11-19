using PRE.Model.Model;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();

            //GetAll
            List<User> users = userService.GetAll();
            foreach (var item in users)
            {
                Console.WriteLine($"{item.IdUser}, {item.FirstName}, {item.LastName}, {item.BirthDate}, {item.Gender}, {item.Email} ");
            }

            //Get User by id
            //User user = userService.GetById(20);
            //Console.WriteLine($"{user.IdUser}, {user.FirstName}, {user.LastName}, {user.BirthDate}, {user.Gender}, {user.Email} ");

            //Insert User
            User user2 = new User("Manuel", "Mendonça", 1984-08-25, , "exemplo@exemplo.pt");
        }
    }
}
