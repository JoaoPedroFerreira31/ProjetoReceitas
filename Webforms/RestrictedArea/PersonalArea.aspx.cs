using PRE.Model.Model;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        public List<Recipe> recipes { get; set; }
        private RecipeService recipeService = new RecipeService();
        private UserService userService = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Membership.GetUser().UserName;
            User user = userService.GetUserByMembershipUsername(userName);
            int id = user.IdUser;

            Recipe recipe = recipeService.GetIdRecipe(id);
            int idRecipe = recipe.IdRecipe;
            Recipe recipeWhereUser = recipeService.GetById(idRecipe);

            recipes.Add(recipeWhereUser);

            Repeater1.DataSource = this.recipes;
            Repeater1.DataBind();
        }
    }
}