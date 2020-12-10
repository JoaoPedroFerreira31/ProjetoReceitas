namespace WindowsFormsApp
{
    partial class InitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReceitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarReceitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.recipesToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.usersMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // recipesToolStripMenuItem
            // 
            this.recipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReceitasToolStripMenuItem,
            this.validarReceitasToolStripMenuItem});
            this.recipesToolStripMenuItem.Name = "recipesToolStripMenuItem";
            this.recipesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.recipesToolStripMenuItem.Text = "Receitas";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.windowToolStripMenuItem.Text = "Ingredientes";
            // 
            // usersMenuStrip
            // 
            this.usersMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllUsersToolStripMenuItem,
            this.blockUsersToolStripMenuItem,
            this.inserirAdministradorToolStripMenuItem});
            this.usersMenuStrip.Name = "usersMenuStrip";
            this.usersMenuStrip.Size = new System.Drawing.Size(80, 20);
            this.usersMenuStrip.Text = "Utilizadores";
            // 
            // viewAllUsersToolStripMenuItem
            // 
            this.viewAllUsersToolStripMenuItem.Name = "viewAllUsersToolStripMenuItem";
            this.viewAllUsersToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.viewAllUsersToolStripMenuItem.Text = "Consultar Utilizadores";
            this.viewAllUsersToolStripMenuItem.Click += new System.EventHandler(this.viewAllUsersToolStripMenuItem_Click);
            // 
            // blockUsersToolStripMenuItem
            // 
            this.blockUsersToolStripMenuItem.Name = "blockUsersToolStripMenuItem";
            this.blockUsersToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.blockUsersToolStripMenuItem.Text = "Editar Utilizadores";
            this.blockUsersToolStripMenuItem.Click += new System.EventHandler(this.blockUsersToolStripMenuItem_Click);
            // 
            // inserirAdministradorToolStripMenuItem
            // 
            this.inserirAdministradorToolStripMenuItem.Name = "inserirAdministradorToolStripMenuItem";
            this.inserirAdministradorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.inserirAdministradorToolStripMenuItem.Text = "Criar Administrador";
            this.inserirAdministradorToolStripMenuItem.Click += new System.EventHandler(this.inserirAdministradorToolStripMenuItem_Click);
            // 
            // verReceitasToolStripMenuItem
            // 
            this.verReceitasToolStripMenuItem.Name = "verReceitasToolStripMenuItem";
            this.verReceitasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verReceitasToolStripMenuItem.Text = "Ver Receitas";
            this.verReceitasToolStripMenuItem.Click += new System.EventHandler(this.verReceitasToolStripMenuItem_Click);
            // 
            // validarReceitasToolStripMenuItem
            // 
            this.validarReceitasToolStripMenuItem.Name = "validarReceitasToolStripMenuItem";
            this.validarReceitasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validarReceitasToolStripMenuItem.Text = "Validar Receitas";
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receitas Estrelares";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewAllUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReceitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarReceitasToolStripMenuItem;
    }
}

