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
    public partial class WebForm7 : System.Web.UI.Page
    {
        private RecipeService recipeService = new RecipeService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            int day = int.Parse(DayTxt.Text);
            int hour = int.Parse(HourTxt.Text);
            int minute = int.Parse(MinuteTxt.Text);

            string nameRecipe = NameTxt.Text;
            string description = DesriptionTxt.Text;
            TimeSpan duration = new TimeSpan(day, hour, minute);
            Difficulty difficulty = (Difficulty)int.Parse(DifficultyDropdown.SelectedValue);
            Category category = (Category)int.Parse(CategoryDropdown.SelectedValue);

            Recipe recipe = new Recipe(nameRecipe, description, duration, difficulty, category);
            recipeService;
        }
    }
}