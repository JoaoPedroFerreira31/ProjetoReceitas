using PRE.Data.Repositories;
using PRE.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Services.Services
{
    public class AccountService
    {
        //Call AccountRepository
        private AccountRepository _repo;

        //Create builders to generate AccountService
        public AccountService()
        {
            _repo = new AccountRepository();
        }

        public List<Account> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
