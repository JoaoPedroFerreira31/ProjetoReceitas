using PRE.Model.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Data.Repositories
{
    public class CommentRepository
    {
        //MSSQL connection string
        private static string _connectionString;

        public CommentRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;
        }

        //MSSQL Table Comment_tbl
        private static int _colIdComment = 0;
        private static int _colCommentText = 1;
        private static int _colDate = 2;
        private static int _colIdRecipe = 3;
        private static int _colIdUser = 4;
        
        public List<Comment> GetAll()
        {
            List<Comment> comments = new List<Comment>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spReadComments";
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                Comment comment = null;
                while (dataReader.Read())
                {
                    comment = new Comment();

                    comment.IdComment = dataReader.GetInt32(_colIdComment);
                    comment.CommentText = dataReader.GetString(_colCommentText);
                    comment.Date = dataReader.GetDateTime(_colDate);
                    comment.IdUser = dataReader.GetInt32(_colIdUser);
                    comment.IdRecipe = dataReader.GetInt32(_colIdRecipe);

                    comments.Add(comment);
                }

                return comments;
            }
        }
    }
}
