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

        public List<Recipe> GetAllRecipesValidated()
        {
            return _repo.GetAllRecipesValidated();
        }

        public Recipe GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Recipe> GetByUserId(int id)
        {
            return _repo.GetByUserId(id);
        }

        public List<Recipe> GetRecipesByCategory(byte category)
        {
            return _repo.GetRecipeByCategory(category);
        }

        public List<Recipe> GetRecipesByName(string name)
        {
            return _repo.GetRecipeByName(name);
        }

        public void Insert(Recipe recipe)
        {
            _repo.Insert(recipe);
        }

        public void InsertFavRecipe(int idRecipe, int idUser)
        {
            _repo.InsertFavRecipe(idRecipe, idUser);
        }

        public List<Recipe> GetIdRecipe(int idUser)
        {
            return _repo.GetIdRecipe(idUser);
        }
    }
}
