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
    public class CategoryRepository
    {
        //MSSQL connection string
        private static string _connectionString;

        public CategoryRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;
        }

        //MSSQL Table Category_tbl
        private static int _colIdCategory = 0;
        private static int _colName = 1;

        //Get all categories from database
        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                 
                SqlCommand cmd = connection.CreateCommand();

                //Query to select all users from Database
                cmd.CommandText = "spReadCategories";
                cmd.CommandType = CommandType.StoredProcedure;


                //EXECUTE
                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Category category = new Category();

                    category.IdCategory = dataReader.GetInt32(_colIdCategory);
                    category.Name = dataReader.GetString(_colName);

                    categories.Add(category);
                }
                return categories;

            }
        }
    }
}
