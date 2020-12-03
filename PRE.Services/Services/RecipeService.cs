using PRE.Data.Repositories;
using PRE.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Services.Services
{
    public class RecipeService
    {
        //Call RecipeRepository
        private RecipeRepository _repo;

        
        //Create builders to generate RecipeService
        public RecipeService()
        {
            _repo = new RecipeRepository();
        }

        public List<Recipe> GetAll()
        {
            return _repo.GetAll();
        }

        public Recipe GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Recipe> GetByUserId(int id)
        {
            return _repo.GetByUserId(id);
        }

        public List<Recipe> GetRecipesByCategoryId(int idCategory)
        {
            return _repo.GetRecipeByCategory(idCategory);
        }

    }
}
