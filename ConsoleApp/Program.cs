using PRE.Model.Model;
using PRE.Model.Model.Util;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            UserService userService = new UserService();
            AccountService accountService = new AccountService();
            RecipeService recipeService = new RecipeService();
            IngredientService ingredientService = new IngredientService();

            /*MembershipUser membership = Membership.GetUser();
            var user = userService.GetLoggedInUser(membership.ProviderName);*/


            //=====================
            //==    Ingredient   ==
            //=====================

            //Insert
            /*Ingredient ingredient = new Ingredient("Ovos");

            ingredientService.Insert(ingredient);
            */

            //GetAll
            List<Ingredient> ingredients = new List<Ingredient>();

            ingredients = ingredientService.GetAll();

            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }


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

            //Get all recipes validated 
            Console.WriteLine("Receitas validadas");
            List<Recipe> recipes1 = new List<Recipe>();

            recipes1 = recipeService.GetAllRecipesValidated();
            foreach (Recipe recipe in recipes1)
            {
                Console.WriteLine(recipe);
            }

            //Get recipe by category
            /*List<Recipe> recipes = new List<Recipe>();
            
            recipes = recipeService.GetRecipesByCategory(3);
            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe);
            }*/

            //Get recipe by name 
            /*List<Recipe> recipes = new List<Recipe>();

            recipes = recipeService.GetRecipesByName("Teste");
            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe);
            }*/
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

            //get user by membership
            User user = userService.GetUserByMembershipUsername("testejp");

            Console.WriteLine($"isto é um membership: {user}");

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
