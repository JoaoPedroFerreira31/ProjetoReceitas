using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
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
            this.recipes = recipeService.GetAllRecipesValidated();
           
            /* Membership.GetUser();
            MembershipUser membershipUser = Membership.GetUser();
            string username = membershipUser.UserName;
            Roles.GetRolesForUser();
            string[] array = Roles.GetRolesForUser();
            Membership*/
        }

        protected void ShowRecipeBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}