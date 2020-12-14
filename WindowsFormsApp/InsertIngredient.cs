using PRE.Model.Model;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class InsertIngredient : Form
    {
        public InsertIngredient()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            IngredientService ingredientService = new IngredientService();

            string name = NameTxt.Text;
            int quantity = int.Parse(QuantityTxt.Text);
            string unit = UnitTxt.Text;

            Ingredient ingredient = new Ingredient(name, quantity, unit);

            ingredientService.Insert(ingredient);

            List<Ingredient> ingredients = ingredientService.GetAll();
            dataGridView1.DataSource = ingredients;
        }

        private void CleanBtn_Click(object sender, EventArgs e)
        {
            NameTxt.Text = "";
            QuantityTxt.Text = "";
            UnitTxt.Text = "";
        }

        private void AllIngredientsBtn_Click(object sender, EventArgs e)
        {
            IngredientService ingredientService = new IngredientService();

            List<Ingredient> ingredients = ingredientService.GetAll();
            dataGridView1.DataSource = ingredients;
        }

        private void InsertIngredient_Load(object sender, EventArgs e)
        {
            IngredientService ingredientService = new IngredientService();

            List<Ingredient> ingredients = ingredientService.GetAll();
            dataGridView1.DataSource = ingredients;
        }
    }
}
