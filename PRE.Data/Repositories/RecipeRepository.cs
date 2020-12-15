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
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;

        //MSSQL Table Recipes_tbl
        private static int _colIdRecipe = 0;
        private static int _colName = 1;
        private static int _colDescription = 2;
        private static int _colDuration = 3;
        private static int _colDifficulty = 4;
        private static int _colIdRating = 5;
        private static int _colIsValidated = 6;
        private static int _colCategory = 7;
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

                //Query to select all recipes from Database
                cmd.CommandText = "spReadRecipes";
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
                    recipe.Duration = dataReader.GetTimeSpan(_colDuration);
                    recipe.Difficulty = (Difficulty)dataReader.GetByte(_colDifficulty);
                    recipe.Rating = (Rating)dataReader.GetByte(_colIdRating);
                    recipe.IsValidated = dataReader.IsDBNull(_colIsValidated) ? false : dataReader.GetBoolean(_colIsValidated); ;
                    recipe.Category = (Category)dataReader.GetByte(_colCategory);
                    recipe.IdUser = dataReader.GetInt32(_colIdUser);
                    
                    recipes.Add(recipe);
                }

                return recipes;
            }
        }

        //Get all recipes from database where validated = true
        public List<Recipe> GetAllRecipesValidated()
        {
            List<Recipe> recipes = new List<Recipe>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spReadRecipesValidated";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Recipe recipe = new Recipe();

                    recipe.IdRecipe = dataReader.GetInt32(_colIdRecipe);
                    recipe.Name = dataReader.GetString(_colName);
                    recipe.Description = dataReader.GetString(_colDescription);
                    recipe.Duration = dataReader.GetTimeSpan(_colDuration);
                    recipe.Difficulty = (Difficulty)dataReader.GetByte(_colDifficulty);
                    recipe.Rating = (Rating)dataReader.GetByte(_colIdRating);
                    recipe.IsValidated = dataReader.IsDBNull(_colIsValidated); 
                    recipe.Category = (Category)dataReader.GetByte(_colCategory);
                    //recipe.User.IdUser = dataReader.GetInt32(_colIdUser);

                    recipes.Add(recipe);
                }

                return recipes;
            }
        }

        //Get Non Validated Recipes
        public List<Recipe> GetNonValidatedRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();

            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spReadNonValidatedRecipes";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Recipe recipe = new Recipe();

                    recipe.IdRecipe = dataReader.GetInt32(_colIdRecipe);
                    recipe.Name = dataReader.GetString(_colName);
                    recipe.Description = dataReader.GetString(_colDescription);
                    recipe.Duration = dataReader.GetTimeSpan(_colDuration);
                    recipe.Difficulty = (Difficulty)dataReader.GetByte(_colDifficulty);
                    recipe.Rating = (Rating)dataReader.GetByte(_colIdRating);
                    recipe.IsValidated = dataReader.GetBoolean(_colIsValidated);
                    recipe.Category = (Category)dataReader.GetByte(_colCategory);
                    //recipe.User.IdUser = dataReader.GetInt32(_colIdUser);

                    recipes.Add(recipe);
                }

                return recipes;
            }
        }


        //Get Recipe by ID from Database
        public Recipe GetById(int id)
        {
            SqlParameter parameter;

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                 
                //SqlCommand cmd = new SqlCommand("spReadRecipesById", connection); 
                SqlCommand cmd = connection.CreateCommand();

                //Query to select all users from Database
                cmd.CommandText = "spReadRecipesById";
                cmd.CommandType = CommandType.StoredProcedure;

                //Access Store Procedure Parameter
                parameter = new SqlParameter("@IdRecipe", id);

                parameter.Direction = ParameterDirection.Input;

                //IdRecipe DataType in Database
                parameter.DbType = DbType.Int32;

                cmd.Parameters.Add(parameter);


                //EXECUTE
                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                Recipe recipe = null;

                while (dataReader.Read())
                {
                    recipe = new Recipe();

                    recipe.IdRecipe = dataReader.GetInt32(_colIdRecipe);
                    recipe.Name = dataReader.GetString(_colName);
                    recipe.Description = dataReader.GetString(_colDescription);
                    recipe.Duration = dataReader.GetTimeSpan(_colDuration);
                    recipe.Difficulty = (Difficulty)dataReader.GetByte(_colDifficulty);
                    recipe.Rating = (Rating)dataReader.GetByte(_colIdRating);
                    recipe.IsValidated = dataReader.GetBoolean(_colIsValidated);
                    recipe.Category = (Category)dataReader.GetByte(_colCategory);
                }

                return recipe;
            }
        }

        //Get Recipes by User from Database
        public List<Recipe> GetByUserId(int id)
        {
            SqlParameter parameter;

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Recipe> recipes = new List<Recipe>();

                //COMMAND                 
                //SqlCommand cmd = new SqlCommand("spReadRecipesByUserId", connection); 
                SqlCommand cmd = connection.CreateCommand();

                //Query to select all users from Database
                cmd.CommandText = "spReadRecipesByUsersId";
                cmd.CommandType = CommandType.StoredProcedure;

                //Access Store Procedure Parameter
                parameter = new SqlParameter("@IdUser", id);

                parameter.Direction = ParameterDirection.Input;

                //IdUser DataType in Database
                parameter.DbType = DbType.Int32;

                cmd.Parameters.Add(parameter);


                //EXECUTE
                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                Recipe recipe = null;

                while (dataReader.Read())
                {
                    recipe = new Recipe();

                    recipe.IdRecipe = dataReader.GetInt32(_colIdRecipe);
                    recipe.Name = dataReader.GetString(_colName);
                    recipe.Description = dataReader.GetString(_colDescription);
                    recipe.Duration = dataReader.GetTimeSpan(_colDuration);
                    recipe.Difficulty = (Difficulty)dataReader.GetByte(_colDifficulty);
                    recipe.Rating = (Rating)dataReader.GetByte(_colIdRating);
                    recipe.IsValidated = dataReader.GetBoolean(_colIsValidated);
                    recipe.Category = (Category)dataReader.GetByte(_colCategory);

                    recipes.Add(recipe);
                }

                return recipes;
            }
        }

        //Get Recipes by Category 
        public List<Recipe> GetRecipeByCategory(int category)
        {
            SqlParameter parameter;

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Recipe> recipes = new List<Recipe>();

                //COMMAND                 
                //SqlCommand cmd = new SqlCommand("spReadRecipesByUserId", connection); 
                SqlCommand cmd = connection.CreateCommand();

                //Query to select all users from Database
                cmd.CommandText = "spReadRecipesByCategory";
                cmd.CommandType = CommandType.StoredProcedure;

                //Access Store Procedure Parameter
                parameter = new SqlParameter("@Category", category);

                parameter.Direction = ParameterDirection.Input;

                //IdUser DataType in Database
                parameter.DbType = DbType.Int32;

                cmd.Parameters.Add(parameter);


                //EXECUTE
                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                Recipe recipe = null;

                while (dataReader.Read())
                {
                    recipe = new Recipe();

                    recipe.IdRecipe = dataReader.GetInt32(_colIdRecipe);
                    recipe.Name = dataReader.GetString(_colName);
                    recipe.Description = dataReader.GetString(_colDescription);
                    recipe.Duration = dataReader.GetTimeSpan(_colDuration);
                    recipe.Difficulty = (Difficulty)dataReader.GetByte(_colDifficulty);
                    recipe.Rating = (Rating)dataReader.GetByte(_colIdRating);
                    recipe.IsValidated = dataReader.GetBoolean(_colIsValidated);
                    recipe.Category = (Category)dataReader.GetByte(_colCategory);
                    recipe.IdUser = dataReader.IsDBNull(_colIdUser)? 0: dataReader.GetInt32(_colIdUser);

                    recipes.Add(recipe);
                }

                return recipes;
            }
        }

        //Get recipes by name 
        public List<Recipe> GetRecipeByName(string name)
        {

            List<Recipe> recipes = new List<Recipe>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spReadRecipeByName";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParameter = new SqlParameter("@Name", name);
                nameParameter.DbType = DbType.String;
                nameParameter.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(nameParameter);

                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Recipe recipe = new Recipe();

                    recipe.IdRecipe = dataReader.GetInt32(_colIdRecipe);
                    recipe.Name = dataReader.GetString(_colName);
                    recipe.Description = dataReader.GetString(_colDescription);
                    recipe.Duration = dataReader.GetTimeSpan(_colDuration);
                    recipe.Difficulty = (Difficulty)dataReader.GetByte(_colDifficulty);
                    recipe.Rating = (Rating)dataReader.GetByte(_colIdRating);
                    recipe.IsValidated = dataReader.GetBoolean(_colIsValidated);
                    recipe.Category = (Category)dataReader.GetByte(_colCategory);

                    recipes.Add(recipe);
                }
            }
            return recipes;
        }

        //Insert Recipe in Database       
        public void Insert(Recipe recipe)
        {
            

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spInsertRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParameter = new SqlParameter();
                nameParameter.ParameterName = "@Name";
                nameParameter.Value = recipe.Name;
                nameParameter.SqlDbType = SqlDbType.NVarChar;
                nameParameter.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(nameParameter);

                cmd.Parameters.AddWithValue("@Description", recipe.Description);
                cmd.Parameters.AddWithValue("@Duration", recipe.Duration);
                cmd.Parameters.AddWithValue("@Difficulty", recipe.Difficulty);
                cmd.Parameters.AddWithValue("@Category", recipe.Category);

                SqlParameter userIdParam = new SqlParameter();
                userIdParam.ParameterName = "@IdUser";
                userIdParam.Value = recipe.IdUser;
                userIdParam.SqlDbType = SqlDbType.Int;
                userIdParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(userIdParam);

                SqlParameter idParameter = new SqlParameter();
                idParameter.ParameterName = "@IdRecipe";
                idParameter.Value = recipe.IdRecipe;
                idParameter.SqlDbType = SqlDbType.Int;
                idParameter.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(idParameter);

                connection.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                int id = (int)idParameter.Value;
                recipe.IdRecipe = id;
            }
        }


        //Add Recipe to Favorite list
        public List<Recipe> InsertFavRecipe(int idRecipe, int idUser)
        {

        }

    }
}
