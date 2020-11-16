using PRE.Model.Model;
using PRE.Model.Model.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Data.Repositories
{
    public class RecipeRepository
    {
        //MSSQL connection string
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ReceitasEstrelares"].ConnectionString;

        //MSSQL Table Recipes_tbl
        private static int _colIdRecipe = 0;
        private static int _colName = 1;
        private static int _colDescription = 2;
        private static int _colDuration = 3;
        private static int _colDifficulty = 4;
        private static int _colIdRating = 5;
        private static int _colIsValidated = 6;
        private static int _colIdCategory = 7;
        private static int _colIdUser = 8;

        //Get all Recipes from Database
        public List<Recipe> GetAll()
        {
            List<Recipe> recipes = new List<Recipe>();

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //COMMAND                 
                SqlCommand cmd = connection.CreateCommand();

                //Query to select all users from Database
                cmd.CommandText = "spReadRecipe";
                cmd.CommandType = CommandType.StoredProcedure;


                //EXECUTE
                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();                

                while (dataReader.Read())
                {
                    Recipe recipe = new Recipe();

                    recipe.IdRecipe = dataReader.GetInt32(_colIdRecipe);
                    recipe.Name = dataReader.GetString(_colName);
                    recipe.Description = dataReader.GetString(_colDescription);
                    recipe.Difficulty = (Difficulty)dataReader.GetInt32(_colDifficulty);
                    recipe.Rating = (Rating)dataReader.GetInt32(_colIdRating);
                    recipe.IsValidated = dataReader.GetBoolean(_colIsValidated);

                    recipes.Add(recipe);
                }
                
                return recipes;
            }
        }

        public Recipe GetById(int id)
        {

        }
    }
}
