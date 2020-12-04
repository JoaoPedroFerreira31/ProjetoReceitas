using PRE.Model.Model;
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
    public class IngredientRepository
    {
        private static string _connectionString;

        public IngredientRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;
        }

        //MSSQL Ingredients Table
        private static int _ColIdIngredient = 0;
        private static int _ColIngredientName = 1;
        private static int _ColIngredientQuantity = 2;
        private static int _ColIngredientUnit = 3;
        
        //Get all ingredients from Database
        public List<Ingredient> GetAll()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spReadIngredients";
                cmd.CommandType = CommandType.StoredProcedure;                

                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Ingredient ingredient = new Ingredient();

                    ingredient.IdIngredient = dataReader.GetInt32(_ColIdIngredient);
                    ingredient.Name = dataReader.GetString(_ColIngredientName);
                    ingredient.Quantity = dataReader.IsDBNull(_ColIngredientQuantity) ? 0 : dataReader.GetInt32(_ColIngredientQuantity);
                    ingredient.Unit = dataReader.IsDBNull(_ColIngredientUnit) ? "" : dataReader.GetString(_ColIngredientUnit);

                    ingredients.Add(ingredient);
                }

                return ingredients;
            }
        }

        //GetIngredientById
        public Ingredient GetById(int id)
        {
            SqlParameter parameter;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spReadIngredientsById";
                cmd.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter("@IdIngredient", id);
                parameter.DbType = DbType.Int32;
                parameter.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(parameter);

                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                Ingredient ingredient = null;

                while (dataReader.Read())
                {
                    ingredient = new Ingredient();

                    ingredient.IdIngredient = dataReader.GetInt32(_ColIdIngredient);
                    ingredient.Name = dataReader.GetString(_ColIngredientName);
                    ingredient.Quantity = dataReader.GetInt32(_ColIngredientQuantity);
                    ingredient.Unit = dataReader.GetString(_ColIngredientUnit);
                }
                return ingredient;
            }
        }

        //Insert Ingredient in Database
        public void Insert(Ingredient ingredient)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spInsertIngredient";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParameter = new SqlParameter();
                nameParameter.ParameterName = "@Name";
                nameParameter.Value = ingredient.Name;
                nameParameter.SqlDbType = SqlDbType.VarChar;
                nameParameter.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(nameParameter);

                SqlParameter quantityParameter = new SqlParameter();
                quantityParameter.ParameterName = "@Quantity";
                quantityParameter.Value = ingredient.Quantity;
                quantityParameter.SqlDbType = SqlDbType.Int;
                quantityParameter.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(quantityParameter);

                SqlParameter unitParameter = new SqlParameter();
                unitParameter.ParameterName = "@Unit";
                unitParameter.Value = ingredient.Unit;
                unitParameter.SqlDbType = SqlDbType.NVarChar;
                unitParameter.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(unitParameter);

                SqlParameter idParameter = new SqlParameter();
                idParameter.ParameterName = "@IdIngredient";
                idParameter.Value = ingredient.IdIngredient;
                idParameter.SqlDbType = SqlDbType.Int;
                idParameter.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(idParameter);

                connection.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                int id = (int)idParameter.Value;
                ingredient.IdIngredient = id;
            }
        }


    }
}
