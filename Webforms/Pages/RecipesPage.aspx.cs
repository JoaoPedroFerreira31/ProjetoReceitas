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
    public partial class WebForm2 : System.Web.UI.Page
    {
        public List<Recipe> recipes { get; set; }
        private RecipeService recipeService = new RecipeService();

        protected void Page_Load(object sender, EventArgs e)
        {            
            this.recipes = recipeService.GetAllRecipesValidated();
            Repeater1.DataSource = this.recipes;
            Repeater1.DataBind();
        }
        
        protected void SearchRecipeBtn_Click(object sender, EventArgs e)
        {
            if(SearchRecipeTxt.Text == "")
            {
                this.recipes = recipeService.GetAllRecipesValidated();
                Repeater1.DataSource = this.recipes;
                Repeater1.DataBind();
            }
            else
            {
                this.recipes = recipeService.GetRecipesByName(SearchRecipeTxt.Text);
                Repeater1.DataSource = this.recipes;
                Repeater1.DataBind();
            }

            
        }
    }
}