using PRE.Data.Repositories;
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
    public partial class ViewUsersForm : Form
    {


        //Connection String
        private static string _cs = ConfigurationManager.ConnectionStrings["ReceitasEstrelaresCS"].ConnectionString;
        SqlConnection connection = new SqlConnection(_cs);

        public ViewUsersForm()
        {
            InitializeComponent();
        }    
        
        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            List<User> getAll = userService.GetAll();
            dataGridView.DataSource= getAll;
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            List<User> getAll = userService.GetAll();
            dataGridView.DataSource = getAll;
        }
            
        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "IdUser")
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
    }
}
