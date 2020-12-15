using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Model.Model
{
    public class Comment
    {
        public int IdComment { get; set; }
        public string CommentText { get; set; }
        public DateTime Date { get; set; }
        public int IdUser { get; set; }
        public int IdRecipe { get; set; }

    }
}
