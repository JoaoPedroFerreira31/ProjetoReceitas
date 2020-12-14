using PRE.Model.Model;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        private RecipeService recipeService = new RecipeService();
        public Recipe recipe;
        public int idRecipe; 

        protected void Page_Load(object sender, EventArgs e)
        {
            idRecipe = int.Parse(Request.QueryString["ItemID"]);
            recipe = recipeService.GetById(idRecipe);


        }
    }
}