﻿using PRE.Model.Model;
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
        private static string _connectionString; 

        public UserRepository()
        {
           _connectionString = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;
        }   

        //MSSQL Table Users_tbl
        private static int _colIdUser = 0;
        private static int _colFirstName = 1;
        private static int _colLastName = 2;
        private static int _colBirthDate = 3;
        private static int _colGender = 4;
        private static int _colEmail = 5;
        private static int _colIdAccount = 6;
        private static int _IdRecipe = 7;
        private static int _colIsAdmin = 8;
        private static int _colBlocked = 9;
        private static int _colMembershipUsername = 10;

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
                    var enumGender = user.Gender = dataReader.IsDBNull(_colGender) ? 0: (Gender)dataReader.GetByte(_colGender);
                    if ((byte)enumGender == 1)
                    {
                        Gender gender = Gender.Male;
                        user.Gender = gender;

                    }
                    else if ((byte)enumGender == 2)
                    {
                        Gender gender = Gender.Female;
                        user.Gender = gender;

                    }
                    else if ((byte)enumGender >= 3)
                    {
                        Gender gender = Gender.Other;
                        user.Gender = gender;
                    }

                    user.Email = dataReader.GetString(_colEmail);
                    //user.Account.IdAccount = dataReader.GetInt32(_colIdAccount);
                    user.IsAdmin = dataReader.IsDBNull(_colIsAdmin) ? false : dataReader.GetBoolean(_colIsAdmin);
                    user.Blocked = dataReader.IsDBNull(_colBlocked) ? false : dataReader.GetBoolean(_colBlocked);

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

                //Query to select user by id from Database
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
                    var enumGender = user.Gender = dataReader.IsDBNull(_colGender) ? 0 : (Gender)dataReader.GetByte(_colGender);
                    if ((byte)enumGender == 0)
                    {
                        Gender gender = Gender.NA;
                        user.Gender = gender;
                    }
                    else if ((byte)enumGender == 1)
                    {
                        Gender gender = Gender.Male;
                        user.Gender = gender;

                    }
                    else if ((byte)enumGender == 2)
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
                    user.IsAdmin = dataReader.IsDBNull(_colIsAdmin) ? false : dataReader.GetBoolean(_colIsAdmin);
                    user.Blocked = dataReader.IsDBNull(_colBlocked) ? false : dataReader.GetBoolean(_colBlocked);

                }

                return user;
            }

        }

        //Get User by FirstName from Database
        public User GetByFirstName(string firstName)
        {
            SqlParameter parameter;

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                 
                //SqlCommand cmd = new SqlCommand("spReadUsersById", connection); 
                SqlCommand cmd = connection.CreateCommand();

                //Query to select user by FirstName from Database
                cmd.CommandText = "spReadUsersByFirstName";
                cmd.CommandType = CommandType.StoredProcedure;

                //Access Store Procedure Parameter
                parameter = new SqlParameter("@FirstName", firstName);

                parameter.Direction = ParameterDirection.Input;

                //FirstName DataType in Database
                parameter.DbType = DbType.String;

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
                    var enumGender = user.Gender = dataReader.IsDBNull(_colGender) ? 0 : (Gender)dataReader.GetByte(_colGender);
                    if ((byte)enumGender == 1)
                    {
                        Gender gender = Gender.Male;
                        user.Gender = gender;

                    }
                    else if ((byte)enumGender == 2)
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
                    user.IsAdmin = dataReader.IsDBNull(_colIsAdmin) ? false : dataReader.GetBoolean(_colIsAdmin);
                    user.Blocked = dataReader.IsDBNull(_colBlocked) ? false : dataReader.GetBoolean(_colBlocked);

                }

                return user;
            }
        }

        //Read user by MembershipUsername 
        public User GetUserByMembershipUsername(string membership)
        {
            User user = null;
            SqlParameter parameter;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spReadUsersByMembership";
                cmd.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter("@MembershipUsername", membership);

                parameter.Direction = ParameterDirection.Input;

                //FirstName DataType in Database
                parameter.DbType = DbType.String;

                cmd.Parameters.Add(parameter);

                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read()) 
                {
                    user = new User();

                    user.IdUser = dataReader.GetInt32(_colIdUser);
                    user.FirstName = dataReader.GetString(_colFirstName);
                    user.LastName = dataReader.GetString(_colLastName);
                    user.BirthDate = dataReader.GetDateTime(_colBirthDate);

                    //Convert GetByte (Tinyint) into Gender Enum 
                    var enumGender = user.Gender = dataReader.IsDBNull(_colGender) ? 0 : (Gender)dataReader.GetByte(_colGender);
                    if ((byte)enumGender == 1)
                    {
                        Gender gender = Gender.Male;
                        user.Gender = gender;

                    }
                    else if ((byte)enumGender == 2)
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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //Query to select all users from Database
                cmd.CommandText = "spInsertUsers";                
                cmd.CommandType = CommandType.StoredProcedure;

                //Add Store Procedure Parameter                
                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@FirstName";
                nameParam.Value = user.FirstName;
                nameParam.SqlDbType = SqlDbType.NVarChar;
                nameParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(nameParam);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Email", user.Email);

                SqlParameter idParam = new SqlParameter();
                idParam.ParameterName = "@IdUser";
                idParam.SqlDbType = SqlDbType.Int;
                idParam.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(idParam);


                //EXECUTE
                connection.Open();                                

                int affectedRows = cmd.ExecuteNonQuery();

                int id = (int)idParam.Value;
                user.IdUser = id;

            }
        }

        //Insert user with membership in database
        public void InsertUserWithMembership(User user, string membershipUsername)
        {
            user.MembershipUsername = membershipUsername;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spInsertUserMembership";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@FirstName";
                nameParam.Value = user.FirstName;
                nameParam.SqlDbType = SqlDbType.NVarChar;
                nameParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(nameParam);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@MembershipUsername", user.MembershipUsername);

                connection.Open();

                int id = (int)cmd.ExecuteScalar();
                user.IdUser = id;

            }
        }

        //Insert Admin in database
        public void InsertAdmin(User user)
        {

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                                 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //Query to insert users in Database
                cmd.CommandText = "spInsertAdmin";
                cmd.CommandType = CommandType.StoredProcedure;

                //Add Store Procedure Parameter                
                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@FirstName";
                nameParam.Value = user.FirstName;
                nameParam.SqlDbType = SqlDbType.NVarChar;
                nameParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(nameParam);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);

                SqlParameter idParam = new SqlParameter();
                idParam.ParameterName = "@IdUser";
                idParam.SqlDbType = SqlDbType.Int;
                idParam.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(idParam);


                //EXECUTE
                connection.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                int id = (int)idParam.Value;
                user.IdUser = id;


            }
        }

        public User GetLoggedInUser(string identityUsername)
        {            
            User user = null;
            SqlParameter identityParameter;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spGetLoggedInUser";
                cmd.CommandType = CommandType.StoredProcedure;

                identityParameter = new SqlParameter("@MembershipUsername", identityUsername);
                identityParameter.Value = user.MembershipUsername;
                identityParameter.SqlDbType = SqlDbType.NVarChar;
                identityParameter.Direction = ParameterDirection.Input;

                connection.Open();                

                SqlDataReader dr = cmd.ExecuteReader();

                user = new User();

                if (dr.Read())
                {
                    user.IdUser = dr.GetInt32(_colIdUser);
                    user.FirstName = dr.GetString(_colFirstName);
                    user.LastName = dr.GetString(_colLastName);
                    
                    //Convert GetByte (Tinyint) into Gender Enum 
                    var enumGender = user.Gender = dr.IsDBNull(_colGender) ? 0 : (Gender)dr.GetByte(_colGender);
                    if ((byte)enumGender == 1)
                    {
                        Gender gender = Gender.Male;
                        user.Gender = gender;

                    }
                    else if ((byte)enumGender == 2)
                    {
                        Gender gender = Gender.Female;
                        user.Gender = gender;

                    }
                    else if ((byte)enumGender >= 3)
                    {
                        Gender gender = Gender.Other;
                        user.Gender = gender;
                    }
                    user.MembershipUsername = dr.GetString(_colMembershipUsername);

                    return user ;
                }
                else
                {
                    throw new Exception("Não existe");
                }
            }

        }
    }
}
