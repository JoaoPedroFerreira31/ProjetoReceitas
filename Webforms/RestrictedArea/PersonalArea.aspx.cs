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
        public List<Recipe> FavList= new List<Recipe>();

        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Membership.GetUser().UserName;
            User user = userService.GetUserByMembershipUsername(userName);
            int id = user.IdUser;

            this.recipes = recipeService.GetIdRecipe(id);
            foreach (Recipe recipe1 in recipes)
            {
                int idRecipe = recipe1.IdRecipe;
                Recipe FavRecipe = recipeService.GetById(idRecipe);
                this.FavList.Add(FavRecipe);
            }

            Repeater1.DataSource = FavList;
            Repeater1.DataBind();

            if (FavList.Count == 1)
            {
                Label1.Visible = false;
            }
            else
                Label1.Visible = true;
        }
    }
}