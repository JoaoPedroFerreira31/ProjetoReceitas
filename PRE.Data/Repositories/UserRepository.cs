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
    public class UserRepository
    {
        //MSSQL connection string
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ReceitasEstrelares"].ConnectionString;

        //MSSQL Table Users_tbl
        private static int _colIdUser = 0;
        private static int _colFirstName = 1;
        private static int _colLastName = 2;
        private static int _colBirthDate = 3;
        private static int _colGender = 4;
        private static int _colEmail = 5;
        private static int _colIsAdmin = 8;

        //Get all users from Database
        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                 
                SqlCommand cmd = connection.CreateCommand();

                //Query to select all users from Database
                cmd.CommandText = "spReadUser";
                cmd.CommandType = CommandType.StoredProcedure;


                //EXECUTE
                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    User user = new User();

                    user.IdUser = dataReader.GetInt32(_colIdUser);
                    user.FirstName = dataReader.GetString(_colFirstName);
                    user.LastName = dataReader.GetString(_colLastName);
                    user.BirthDate = dataReader.GetDateTime(_colBirthDate);
                    user.Gender = (Gender)dataReader.GetByte(_colGender);
                    user.Email = dataReader.GetString(_colEmail);
                    user.IsAdmin = dataReader.GetBoolean(_colIsAdmin);

                    users.Add(user);
                }
                return users;

            }

            //Get user by ID from Database
            Public User GetById(int id)
            {
                //CONNECTION
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {

                    //COMMAND                 
                    SqlCommand cmd = connection.CreateCommand();

                    //Query to select all users from Database
                    cmd.CommandText = "spReadUserById";
                    cmd.CommandType = CommandType.StoredProcedure;


                    //EXECUTE
                    connection.Open();

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    User user = null;

                    while (dataReader.Read())
                    {
                        

                        user.IdUser = dataReader.GetInt32(_colIdUser);
                        user.FirstName = dataReader.GetString(_colFirstName);
                        user.LastName = dataReader.GetString(_colLastName);
                        user.BirthDate = dataReader.GetDateTime(_colBirthDate);
                        user.Gender = (Gender)dataReader.GetByte(_colGender);
                        user.Email = dataReader.GetString(_colEmail);
                        user.IsAdmin = dataReader.GetBoolean(_colIsAdmin);


                    }
                    return user;

                }


                //Insert User in Database
            }
        }
    } 
}
