using PRE.Model.Model;
using PRE.Model.Model.Util;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public List<Recipe> recipes = new List<Recipe>();
        private RecipeService recipeService = new RecipeService();
        public int category;
        public string categoryName;

        protected void Page_Load(object sender, EventArgs e)
        {
            category = int.Parse(Request.QueryString["Category"]);
            categoryName = Request.QueryString["CategoryName"]; 
            
            this.recipes = recipeService.GetRecipesByCategory((byte)category);
            Repeater1.DataSource = this.recipes;
            Repeater1.DataBind();
        }
    }
}