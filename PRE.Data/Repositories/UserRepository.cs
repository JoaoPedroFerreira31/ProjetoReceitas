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
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;

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
                    
                    //Convert GetByte (Tinyint) into Gender Enum 
                    var EnumGender = user.Gender = (Gender)dataReader.GetByte(_colGender);
                    if ((byte)EnumGender == 1)
                    {
                        Gender gender = Gender.Male;
                        user.Gender = gender;

                    }
                    else if ((byte)EnumGender == 2)
                    {
                        Gender gender = Gender.Female;
                        user.Gender = gender;

                    }
                    else if ((byte)EnumGender >= 3)
                    {
                        Gender gender = Gender.Other;
                        user.Gender = gender;
                    }

                    user.Email = dataReader.GetString(_colEmail);
                    //user.IsAdmin = dataReader.GetBoolean(_colIsAdmin);

                    users.Add(user);
                }
                return users;

            }
        }

        //Get user by ID from Database
        public User GetById(int id)
        {
            SqlParameter parameter;

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                 
                //SqlCommand cmd = new SqlCommand("spReadUsersById", connection); 
                SqlCommand cmd = connection.CreateCommand();

                //Query to select all users from Database
                cmd.CommandText = "spReadUsersById";
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

                User user = null;

                while (dataReader.Read())
                {
                    user = new User();

                    user.IdUser = dataReader.GetInt32(_colIdUser);
                    user.FirstName = dataReader.GetString(_colFirstName);
                    user.LastName = dataReader.GetString(_colLastName);
                    user.BirthDate = dataReader.GetDateTime(_colBirthDate);

                    //Convert GetByte (Tinyint) into Gender Enum 
                    var EnumGender = user.Gender = (Gender)dataReader.GetByte(_colGender);
                    if((byte)EnumGender == 1)
                    {
                        Gender gender = Gender.Male;
                        user.Gender =  gender;
                    
                    }
                    else if((byte)EnumGender == 2)
                    {
                        Gender gender = Gender.Female;
                        user.Gender = gender;

                    }
                    else
                    {
                        Gender gender = Gender.Other;
                        user.Gender = gender;
                    }

                    user.Email = dataReader.GetString(_colEmail);
                    //user.IsAdmin = dataReader.GetBoolean(_colIsAdmin);

                }

                return user;
            }

        }

        //Insert User in Database        
        public void Insert(User user)
        {

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                 
                //SqlCommand cmd = new SqlCommand("spInsertUsers", connection); 
                //SqlCommand cmd = connection.CreateCommand();
                SqlCommand cmd = new SqlCommand();

                //Query to select all users from Database
                cmd.CommandText = "spInsertUsers";
                cmd.CommandType = CommandType.StoredProcedure;

                //Add Store Procedure Parameter
                
                //FirstName
                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName";
                firstName.Value = user.FirstName;
                firstName.SqlDbType = SqlDbType.NVarChar;

                //LastName
                SqlParameter LastName = new SqlParameter();
                LastName.ParameterName = "@LastName";
                LastName.Value = user.LastName;
                LastName.SqlDbType = SqlDbType.NVarChar;

                //BirthDate
                SqlParameter birthDate = new SqlParameter();
                birthDate.ParameterName = "@BirthDate";
                birthDate.Value = user.BirthDate;
                birthDate.SqlDbType = SqlDbType.DateTime;

                //Gender
                SqlParameter gender = new SqlParameter();
                gender.ParameterName = "@Gender";
                gender.Value = user.Gender;
                gender.SqlDbType = SqlDbType.TinyInt;

                //Email
                SqlParameter email = new SqlParameter();
                email.ParameterName = "@Email";
                email.Value = user.Email;
                email.SqlDbType = SqlDbType.NVarChar;

                cmd.Parameters.Add(firstName);    //parameter = new SqlParameter("@IdUser", );
                cmd.Parameters.Add(LastName);
                cmd.Parameters.Add(birthDate);
                cmd.Parameters.Add(gender);
                cmd.Parameters.Add(email);
                
                //cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime);
                //cmd.Parameters.Add("@Gender", SqlDbType.TinyInt);
                //cmd.Parameters.Add("@Email", SqlDbType.NVarChar);

                //parameter.Direction = ParameterDirection.Input;

                //IdUser DataType in Database
                //parameter.DbType = DbType.Int32;
                //cmd.Parameters.Add(parameter);

                //EXECUTE
                connection.Open();
                int id = (int)cmd.ExecuteScalar();

                user.IdUser = id;

            }
        }
    }
}
