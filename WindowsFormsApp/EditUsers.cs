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
    public partial class EditUsers : Form
    {
        //Connection String
        private static string _cs = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;
        SqlConnection connection = new SqlConnection(_cs);

        public EditUsers()
        {
            InitializeComponent();
        }

        private void EditUsers_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            List<User> users = userService.GetAll();
            dataGridView.DataSource = users;
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            List<User> users = userService.GetAll();
            dataGridView.DataSource = users;
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "IdUser")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT IdUser, FirstName, LastName, Gender, Email, BirthDate, IsAdmin, Blocked FROM Users_tbl WHERE IdUser LIKE '" + textBox_Id.Text + "%'", connection);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text == "FirstName")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT IdUser, FirstName, LastName, Gender, Email, BirthDate, IsAdmin, Blocked FROM Users_tbl WHERE FirstName LIKE '" + textBox_Id.Text + "%'", connection);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text == "LastName")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT IdUser, FirstName, LastName, Gender, Email, BirthDate, IsAdmin, Blocked FROM Users_tbl WHERE LastName LIKE '" + textBox_Id.Text + "%'", connection);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            else if (comboBox1.Text == "Email")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT IdUser, FirstName, LastName, Gender, Email, BirthDate, IsAdmin, Blocked FROM Users_tbl WHERE Email LIKE '" + textBox_Id.Text + "%'", connection);
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
                    string query = @"Update Users_tbl Set IsAdmin = @IsAdmin, Blocked = @Blocked  Where IdUser = @IdUser";

                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@IdUser", row.Cells["IdUser"].Value); //reading Id of a particular record
                    cmd.Parameters.AddWithValue("@Blocked", SqlDbType.Bit).Value = (Convert.ToBoolean(row.Cells["Blocked"].Value) ? 1 : 0);
                    cmd.Parameters.AddWithValue("@IsAdmin", SqlDbType.Bit).Value = (Convert.ToBoolean(row.Cells["IsAdmin"].Value) ? 1 : 0);

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
