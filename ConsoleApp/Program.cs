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
            List<Recipe> recipes = recipeService.GetAll();

            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe);
            }

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
            //User user = userService.GetById(20);
            //Console.WriteLine($"{user.IdUser}, {user.FirstName}, {user.LastName}, {user.BirthDate}, {user.Gender}, {user.Email} ");

            //Insert User
            /*int year = 1963;
            int month = 06;
            int day = 16;

            User Manuel = new User("Manuel", "Mendonça", new DateTime(year, month, day), Gender.Male , "exemplo@exemplo.pt", false, false);

            userService.Insert(Manuel);*/

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
