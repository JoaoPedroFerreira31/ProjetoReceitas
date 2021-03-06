﻿using PRE.Model.Model;
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
    public partial class ViewIngredientForm : Form
    {
        //Connection String
        private static string _cs = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;
        SqlConnection connection = new SqlConnection(_cs);

        public ViewIngredientForm()
        {
            InitializeComponent();
        }

        private void ViewIngredientForm_Load(object sender, EventArgs e)
        {
            IngredientService ingredientService = new IngredientService();

            List<Ingredient> ingredients = ingredientService.GetAll();
            dataGridView.DataSource = ingredients;
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            IngredientService ingredientService = new IngredientService();

            List<Ingredient> ingredients = ingredientService.GetAll();
            dataGridView.DataSource = ingredients;
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Ingredients_tbl WHERE Name LIKE '" + textBox_Id.Text + "%'", connection);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows) //looping through each records in datagridview
                {
                    SqlCommand cmd;

                    //Update query
                    string query = @"Update Ingredients_tbl Set IsValidated = @Isvalidated Where IdIngredient = @IdIngredient";

                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@IdIngredient", row.Cells["IdIngredient"].Value);
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
