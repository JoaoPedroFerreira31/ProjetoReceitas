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

        public Comment GetById(int id)
        {

            SqlParameter parameter;

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //Query to select all users from Database
                cmd.CommandText = "spReadCommentById";
                cmd.CommandType = CommandType.StoredProcedure;

                //Access Store Procedure Parameter
                parameter = new SqlParameter("@IdComment", id);

                parameter.Direction = ParameterDirection.Input;

                //IdRecipe DataType in Database
                parameter.DbType = DbType.Int32;

                cmd.Parameters.Add(parameter);


                //EXECUTE
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
                }

                return comment;
            }
        }
        
        public void Insert(Comment comment)
        {

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                                 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //Query to select all users from Database
                cmd.CommandText = "spInsertComment";
                cmd.CommandType = CommandType.StoredProcedure;

                //Add Store Procedure Parameter                
                SqlParameter commentParam = new SqlParameter();
                commentParam.ParameterName = "@Comment";
                commentParam.Value = comment.CommentText;
                commentParam.SqlDbType = SqlDbType.NVarChar;
                commentParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(commentParam);
                cmd.Parameters.AddWithValue("@Date", comment.Date);
                cmd.Parameters.AddWithValue("@IdUser", comment.IdUser);
                cmd.Parameters.AddWithValue("@IdRecipe", comment.IdRecipe);

                //EXECUTE
                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void InsertIntoJoiningTbl(int idComment, int idRecipe, int idUser)
        {

            //CONNECTION
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                //COMMAND                                 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                //Query to select all users from Database
                cmd.CommandText = "spInsertCommentIntoJoinTbl";
                cmd.CommandType = CommandType.StoredProcedure;

                //Add Store Procedure Parameter                
                SqlParameter commentParam = new SqlParameter("@IdComment", idComment);
                commentParam.DbType = DbType.Int32;
                commentParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(commentParam);

                SqlParameter recipeParam = new SqlParameter("@IdRecipe", idRecipe);
                commentParam.DbType = DbType.Int32;
                commentParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(recipeParam);

                SqlParameter userParam = new SqlParameter("@IdUser", idUser);
                commentParam.DbType = DbType.Int32;
                commentParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(userParam);

                //EXECUTE
                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public List<Comment> GetCommentWhereIdRecipe(int idRecipe)
        {
            List<Comment> comments = new List<Comment>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spReadIdComment";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter recipeParam = new SqlParameter("@IdRecipe", idRecipe);
                recipeParam.DbType = DbType.Int32;
                recipeParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(recipeParam);

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
            }
            return comments;
        }

        //Get comment from joining tbl
        public List<Comment> GetIdComment(int idRecipe)
        {
            List<Comment> comments = new List<Comment>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "spReadIdCommentJoin";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter idParam = new SqlParameter("@IdRecipe", idRecipe);
                idParam.DbType = DbType.Int32;
                idParam.Direction = ParameterDirection.Input;

                cmd.Parameters.Add(idParam);

                connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                Comment comment = null;

                while (dataReader.Read())
                {
                    comment = new Comment();
                    comment.IdComment = dataReader.GetInt32(_colIdComment);

                    comments.Add(comment);
                }
                return comments;
            }
        }
    }
}
