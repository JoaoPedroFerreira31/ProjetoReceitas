﻿using System;
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

        //Button Utilizadores -- Consultar Utilizadores
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

        //Button Utilizadores -- Editar Utilizadores
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

        //Button File - Exit
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        //Button Utilizadores -- Inserir Administrador
        private void inserirAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open InsertAdminForm
            InsertAdminForm insertAdmin = new InsertAdminForm();
            if (ActiveMdiChild != null)
            {
                this.Show();
            }
            else
            {
                 insertAdmin.MdiParent = this;
                 insertAdmin.Show();
            }
        }

        private void verReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open ViewRecipesForm
            ViewRecipesForm recipesForm = new ViewRecipesForm();
            if (ActiveMdiChild != null)
            {
                this.Show();
            }
            else
            {
                recipesForm.MdiParent = this;
                recipesForm.Show();
            }
        }

        private void validarReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open EditRecipesForm
            EditRecipesForm editRecipesForm = new EditRecipesForm();
            if (ActiveMdiChild != null)
            {
                this.Show();
            }
            else
            {
                editRecipesForm.MdiParent = this;
                editRecipesForm.Show();
            }
        }

        private void verIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ViewIngredientForm ingredientForm = new ViewIngredientForm();
            if (ActiveMdiChild != null)
            {
                this.Show();
            }
            else
            {
                ingredientForm.MdiParent = this;
                ingredientForm.Show();
            }
        }

        private void adicionarIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            InsertIngredient ingredientForm = new InsertIngredient();
            if (ActiveMdiChild != null)
            {
                this.Show();
            }
            else
            {
                ingredientForm.MdiParent = this;
                ingredientForm.Show();
            }
        }
    }
}
