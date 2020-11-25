﻿using PRE.Model.Model;
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
            /*User user = userService.GetById(39);
            Console.WriteLine(user);*/

            //Get User by FirstName
            User user = userService.GetByFirstName("Liliana");
            Console.WriteLine(user);

            //Insert User
            /*int year = 1997;
            int month = 2;
            int day = 24;

            User user = new User("Jorge", "Marques", new DateTime(year, month, day), Gender.Male, "exemplo@exemplo.pt");

            userService.Insert(user);*/

            //Insert Admin
            /*int year = 1986;
            int month = 2;
            int day = 4;

            User user = new User("Miguel", "Cabral", new DateTime(year, month, day), Gender.Male, "exemplo@exemplo.pt", true);

            userService.InsertAdmin(user);*/


            //GetAll
            /*Console.WriteLine("==== User GetAll() ====");
            List<User> users = userService.GetAll();
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }*/
        }
    }
}
