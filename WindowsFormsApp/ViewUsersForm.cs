using PRE.Model.Model;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        DataTable table;

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

        private void btnPesquisarId_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();            

            /*int id = int.Parse(textBox_Id.Text);
            User getById = userService.GetById(id) ;
            dataGridView.DataSource = getById;
            dataGridView.Refresh();*/

            DataTable dt = new DataTable();
            
            
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            List<User> getAll = userService.GetAll();
            dataGridView.DataSource = getAll;
        }
    }
}
