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
        public User User { get; set; }

        //Create Override Method
        public override string ToString()
        {
            return $"{IdAccount}, {Username}, {Password}";
        }
    }
}