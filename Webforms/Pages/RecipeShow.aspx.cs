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

        protected void addToFavListBtn_Click(object sender, EventArgs e)
        {
            idRecipe = int.Parse(Request.QueryString["ItemID"]);
            
            UserService userService = new UserService();

            bool isOnline = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            if(isOnline == false)
            {
                Response.Redirect("~/Accounts/Login.aspx");
            }
            else
            {
                string userName = Membership.GetUser().UserName;
                User user = userService.GetUserByMembershipUsername(userName);
                int id = user.IdUser;

                recipeService.InsertFavRecipe(idRecipe, id);
                Label1.Text = "Receita Adicionada aos Favoritos";
                Label1.Visible = true;
            }                                    
        }
    }
}