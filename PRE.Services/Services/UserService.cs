using PRE.Data.Repositories;
using PRE.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Services.Services
{
    public class UserService
    {
        private UserRepository _repo;

        public UserService()
        {
            _repo = new UserRepository();
        }

        public List<User> GetAll()
        {
            return _repo.GetAll();
        }

        //public User Insert()
        //{
        //return _repo.Insert();
        //}
    }
}
