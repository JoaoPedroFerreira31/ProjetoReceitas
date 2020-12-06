using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PRE.Model.Model;
using PRE.Services.Services;

namespace Webforms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Recipe> recipes { get; set; }
        private RecipeService recipeService = new RecipeService(); 

        protected void Page_Load(object sender, EventArgs e)
        {

            this.recipes = recipeService.GetAll();
        }
    }
}