namespace WindowsFormsApp
{
    partial class ViewUsersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.btnPesquisarId = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(161, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserir IdUser";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(250, 19);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(67, 20);
            this.textBox_Id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(422, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserir FirstName";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(530, 18);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(173, 20);
            this.textBox_FirstName.TabIndex = 4;
            // 
            // btnPesquisarNome
            // 
            this.btnPesquisarNome.Location = new System.Drawing.Point(709, 17);
            this.btnPesquisarNome.Name = "btnPesquisarNome";
            this.btnPesquisarNome.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarNome.TabIndex = 5;
            this.btnPesquisarNome.Text = "Pesquisar";
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarId
            // 
            this.btnPesquisarId.Location = new System.Drawing.Point(323, 17);
            this.btnPesquisarId.Name = "btnPesquisarId";
            this.btnPesquisarId.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarId.TabIndex = 6;
            this.btnPesquisarId.Text = "Pesquisar";
            this.btnPesquisarId.UseVisualStyleBackColor = true;
            this.btnPesquisarId.Click += new System.EventHandler(this.btnPesquisarId_Click);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(14, 17);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(128, 23);
            this.btnVerTodos.TabIndex = 7;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(770, 361);
            this.dataGridView.TabIndex = 8;
            // 
            // ViewUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.btnPesquisarId);
            this.Controls.Add(this.btnPesquisarNome);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label1);
            this.Name = "ViewUsersForm";
            this.Text = "Consultar Utilizadores";
            this.Load += new System.EventHandler(this.ViewUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Button btnPesquisarNome;
        private System.Windows.Forms.Button btnPesquisarId;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}