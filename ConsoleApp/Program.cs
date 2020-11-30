using PRE.Model.Model;
using PRE.Model.Model.Util;
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
            AccountService accountService = new AccountService();
            RecipeService recipeService = new RecipeService();
            CategoryService categoryService = new CategoryService();

            //=====================
            //==     Category    ==
            //=====================

            //GetAll
            List<Category> categories = new List<Category>();

            categories = categoryService.GetAll();

            Console.WriteLine(categories);
            
            
            //=====================
            //==      Recipe     ==
            //=====================

            //GetAll
            /*List<Recipe> recipes = recipeService.GetAll();

            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe);
            }*/

            //Get Recipe By Id
            //Insert Recipe
            //Get Recipe by User Id


            //=====================
            //==     Account     ==
            //=====================

            //GetAll
            /*List<Account> accounts = accountService.GetAll();

            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }*/

            //Get Account by id            
            //Insert Account            


            //=====================
            //==      USER       ==
            //=====================

            //Get User by id
            /*User user = userService.GetById(36);
            Console.WriteLine(user);*/

            //Get User by FirstName
            /*User user = userService.GetByFirstName("Liliana");
            Console.WriteLine(user);*/

            //Insert User
            /*int year = 1977;
            int month = 8;
            int day = 3;

            User user = new User("Diogo", "Pinto", new DateTime(year, month, day), Gender.Male, "exemplo@exemplo.pt");

            userService.Insert(user);*/

            //Insert Admin
            /*int year = 1987;
            int month = 8;
            int day = 16;

            User user = new User("Ruben", "Sousa", new DateTime(year, month, day), Gender.Male, "exemplo@exemplo.pt", true);

            userService.InsertAdmin(user);*/


            //GetAll
            Console.WriteLine("==== User GetAll() ====");
            List<User> users = userService.GetAll();
            foreach (User item in users)
            {
                Console.WriteLine(item);
            }
                
            
        }
    }
}
