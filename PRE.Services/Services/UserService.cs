using PRE.Data.Repositories;
using PRE.Model.Model;
using PRE.Model.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Services.Services
{
    public class UserService
    {
        //Call UserRepository
        private UserRepository _repo;

        //Create builders to generate UserService
        public UserService()
        {
            _repo = new UserRepository();
        }

        public List<User> GetAll()
        {
            return _repo.GetAll();
        }

        public User GetById(int id)
        {
            
            return _repo.GetById(id);
        }

        public void Insert(User user)
        {
            
           // if (user == null)
           //     throw new Exception("Impossível isto ser null");

            //if (user.account == null)
            //    throw new exception("impossível isto ser null");

            // verificar username tem as caracterisitcas
            //if (_accountRepo.CheckUsername(user.Account.Username))
                //throw new Exception("Username already exists");

            _repo.Insert(user);
        }
    }
}
