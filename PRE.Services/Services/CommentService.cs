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

        public Comment GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Comment> GetCommentWhereIdRecipe(int idRecipe)
        {
            return _repo.GetCommentWhereIdRecipe(idRecipe);
        }

        public void InsertIntoJoiningTbl(int idComment, int idRecipe, int idUser)
        {
            _repo.InsertIntoJoiningTbl(idComment, idRecipe, idUser);
        }

        public void Insert(Comment comment)
        {
            _repo.Insert(comment);
        }

        //get comment join
        public List<Comment> GetIdComment(int idRecipe)
        {
            return _repo.GetIdComment(idRecipe);
        }
    }
}
