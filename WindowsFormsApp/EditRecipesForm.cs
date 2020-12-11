using PRE.Model.Model;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class EditRecipesForm : Form
    {
        //Connection String
        private static string _cs = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;
        SqlConnection connection = new SqlConnection(_cs);

        public EditRecipesForm()
        {
            InitializeComponent();
        }

        private void EditRecipesForm_Load(object sender, EventArgs e)
        {
            RecipeService recipeService = new RecipeService();

            List<Recipe> recipes = recipeService.GetAll();
            dataGridView.DataSource = recipes;
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            RecipeService recipeService = new RecipeService();

            List<Recipe> recipes = recipeService.GetAll();
            dataGridView.DataSource = recipes;
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "IdRecipe")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Recipes_tbl WHERE IdRecipe LIKE '" + textBox_Id.Text + "%'", connection);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text == "Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Recipes_tbl WHERE Name LIKE '" + textBox_Id.Text + "%'", connection);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text == "Description")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Recipes_tbl WHERE Description LIKE '" + textBox_Id.Text + "%'", connection);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text == "Category")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Recipes_tbl WHERE Category LIKE '" + textBox_Id.Text + "%'", connection);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows) //looping through each records in datagridview
                {
                    SqlCommand cmd;

                    //Update query
                    string query = @"Update Recipes_tbl Set IsValidated = @Isvalidated Where IdRecipe = @IdRecipe";

                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@IdRecipe", row.Cells["IdRecipe"].Value);
                    cmd.Parameters.AddWithValue("@IsValidated", SqlDbType.Bit).Value = (Convert.ToBoolean(row.Cells["IsValidated"].Value) ? 1 : 0);

                    connection.Open();

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
                MessageBox.Show("O update foi guardado na tabela.", "Informação");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString(), "Error");
            }
        }
    }
}
