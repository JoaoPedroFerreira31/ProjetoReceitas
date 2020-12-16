using PRE.Model.Model;
using PRE.Model.Model.Util;
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
    public partial class WebForm7 : System.Web.UI.Page
    {
        private RecipeService recipeService = new RecipeService();
        private UserService userService = new UserService();
        private IngredientService ingredientService = new IngredientService();
        public int idRecipe = 0;
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddRecipeBtn_Click(object sender, EventArgs e)
        { 
            string userName = Membership.GetUser().UserName;
            User user = userService.GetUserByMembershipUsername(userName);
            int id = user.IdUser;

            string nameRecipe = NameTxt.Text;
            string description = DesriptionTxt.Text;
            TimeSpan duration = TimeSpan.Parse(DurationTxt.Text);
            Difficulty difficulty = (Difficulty)int.Parse(DifficultyDropdown.SelectedValue);
            Category category = (Category)int.Parse(CategoryDropdown.SelectedValue);

            Recipe recipe = new Recipe(nameRecipe, description, duration, difficulty, category, id);
            recipeService.Insert(recipe);
            idRecipe = recipe.IdRecipe;            

            Label1.Text = "Receita em Fila para validação";
            Label1.Visible = true;
        }

        protected void AddIngredientBtn_Click(object sender, EventArgs e)
        {
            string nameIngredient = nameIngrTxt.Text;
            int quantityIngredient = int.Parse(quantityIngrTxt.Text);
            string unitIngredient = UnitIngrTxt.Text;

            Ingredient ingredient = new Ingredient(nameIngredient, quantityIngredient, unitIngredient);

            ingredientService.Insert(ingredient);
            int idIngredient = ingredient.IdIngredient;

            recipeService.InsertIngredientInRecipe(idRecipe, idIngredient);

            Label1.Text = "Ingrediente Adicionado";
            Label1.Visible = true;

            nameIngrTxt.Text = "";
            quantityIngrTxt.Text = "";
            UnitIngrTxt.Text = "";

        }
    }
}