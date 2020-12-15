using PRE.Data.Repositories;
using PRE.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Services.Services
{
    public class CommentService
    {
        //Call CommentRepository
        private CommentRepository _repo;


        //Create builders to generate CommentService
        public CommentService()
        {
            _repo = new CommentRepository();
        }

        public List<Comment> GetAll()
        {
            return _repo.GetAll();
        }

        public void Insert(Comment comment)
        {
            _repo.Insert(comment);
        }
    }
}
