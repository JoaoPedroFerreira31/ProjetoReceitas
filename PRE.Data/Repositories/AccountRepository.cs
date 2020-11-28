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
    public class AccountRepository
    {
        //MSSQL connection string
        private static string _connectionString;

        public AccountRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;
        }

        //MSSQL Table Accounts_tbl
        private static int _colIdAccount = 0;
        private static int _colUsername = 1;
        private static int _colPassword = 2;
        private static int _colIdUser = 3;

        //Get all accounts from Database
        public List<Account> GetAll()
        {
            List<Account> accounts = new List<Account>();

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                 
                SqlCommand cmd = connection.CreateCommand();

                //Query to select all accounts from Database
                cmd.CommandText = "spReadAccounts";
                cmd.CommandType = CommandType.StoredProcedure;


                //EXECUTE
                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Account account = new Account();

                    account.IdAccount = dataReader.GetInt32(_colIdAccount);
                    account.Username = dataReader.GetString(_colUsername);
                    account.Password = dataReader.GetString(_colPassword);
                    //account.IdUser = (User)dataReader.GetInt32(_colIdUser);

                    accounts.Add(account);
                }
                return accounts;
            }
        }

        //Get account by id from database 
        public Account GetById(int id)
        {
            SqlParameter parameter;

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //COMMAND
                SqlCommand cmd = connection.CreateCommand();

                //Query to select all accounts from Database
                cmd.CommandText = "spReadAccountsById";
                cmd.CommandType = CommandType.StoredProcedure;

                //Access Store Procedure Parameter
                parameter = new SqlParameter("@IdAccount", id);

                parameter.Direction = ParameterDirection.Input;

                //IdUser DataType in Database
                parameter.DbType = DbType.Int32;

                cmd.Parameters.Add(parameter);

                //EXECUTE
                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                Account account = null;

                while (dataReader.Read())
                {

                    account = new Account();

                    account.IdAccount = dataReader.GetInt32(_colIdAccount);
                    account.Username = dataReader.GetString(_colUsername);
                    account.Password = dataReader.GetString(_colPassword);
                    //account.IdUser = dataReader.GetInt32(_colIdUser);

                }
                return account;
            }
        }

        //Insert account in database 
        public void Insert(Account account)
        {
            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //COMMAND
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spInsertAccounts";

                cmd.Parameters.AddWithValue("@UserName", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@IdUser", account.User.IdUser);

                SqlParameter idParam = new SqlParameter();
                idParam.ParameterName = "@IdAccount";
                idParam.SqlDbType = SqlDbType.Int;
                idParam.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(idParam);

                //EXECUTE
                connection.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                int id = (int)idParam.Value;
                account.IdAccount = id;

            }
        }              
    } 
}
