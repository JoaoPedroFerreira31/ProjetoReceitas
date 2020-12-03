using PRE.Data.Repositories;
using PRE.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Services.Services
{
    public class IngredientService
    {
        private IngredientRepository _repo;

        public IngredientService()
        {
            _repo = new IngredientRepository();
        }

        public List<Ingredient> GetAll()
        {
            return _repo.GetAll();
        }

        public Ingredient GetById(int id)
        {
            return _repo.GetById(id);
        }
    }
}
