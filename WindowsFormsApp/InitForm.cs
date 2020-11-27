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
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void viewAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open ViewUsersForm
            ViewUsersForm viewUsers = new ViewUsersForm();
            if (ActiveMdiChild != null)
            {
                this.Show();
            }
            else
            {
                viewUsers.MdiParent = this;
                viewUsers.Show();
            }
        }

        

        private void blockUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open EditUsersForm
            EditUsers editUsers = new EditUsers();
            if (ActiveMdiChild != null)
            {
                this.Show();
            }
            else
            {
                editUsers.MdiParent = this;
                editUsers.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }
    }
}
