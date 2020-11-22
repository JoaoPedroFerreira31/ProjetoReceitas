using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Model.Model
{
    public class Account
    {
        public int IdAccount { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User IdUser { get; set; }


        //Create builders to generate users
        public Account()
        {

        }

        public Account(int idAccount, string username, string password, User idUser)
        {
            IdAccount = idAccount;
            Username = username;
            Password = password;
            IdUser = idUser;
        }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
            
        }
    }

}