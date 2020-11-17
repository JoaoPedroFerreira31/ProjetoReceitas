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

            User user = userService.GetById(20);

            
            Console.WriteLine(user);
            


            Console.WriteLine();

            

        }
    }
}
