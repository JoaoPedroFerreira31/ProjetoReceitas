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

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
