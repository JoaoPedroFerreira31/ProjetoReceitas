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
        //Call Repositories
        private UserRepository _repo;
        private AccountRepository _accountRepo;

        //Create builders to generate UserService
        public UserService()
        {
            _repo = new UserRepository();
            _accountRepo = new AccountRepository();
        }

        //Get all Users
        public List<User> GetAll()
        {
            return _repo.GetAll();
        }

        //Get User by id
        public User GetById(int id)
        {
            
            return _repo.GetById(id);
        }

        public User GetByFirstName(string firstName)
        {
            return _repo.GetByFirstName(firstName);
        }

        //Insert User
        public void Insert(User user)
        {
            if (user == null)
                throw new Exception("User não pode ser null");

            if (user.FirstName == null)
                throw new Exception("User nome não pode ser null");

            _repo.Insert(user);

            user.Account.User = user;

            _accountRepo.Insert(user.Account); 
        }
        
        //Insert Admin
        public void InsertAdmin(User user)
        {
            if (user == null)
                throw new Exception("User não pode ser null");

            if (user.FirstName == null)
                throw new Exception("User nome não pode ser null");

            _repo.InsertAdmin(user);

            user.Account.User = user;

            _accountRepo.Insert(user.Account);
        }


    }
}
