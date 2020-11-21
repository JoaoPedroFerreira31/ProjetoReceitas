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
        public List<Account> getAll()
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
                    account.IdUser = (User)dataReader.GetInt32(_colIdUser);
                    
                    accounts.Add(account);
                }
                return accounts;
            }
        }

    }
}
