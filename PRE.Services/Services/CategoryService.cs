using PRE.Data.Repositories;
using PRE.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Services.Services
{
    public class CategoryService
    {
        
        private CategoryRepository _repo;

        public CategoryService()
        {
            _repo = new CategoryRepository();
        }

        //Get all categories
        public List<Category> GetAll()
        {
            return _repo.GetAll();
        }

        public void Insert(Category category)
        {
            _repo.Insert(category);
        }
        
    }
}
