namespace Instituicao
{
    partial class FrmConsulta
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.Status2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MatAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(531, 294);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 19;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Status2
            // 
            this.Status2.DataPropertyName = "Status2";
            this.Status2.HeaderText = "STATUS (2)";
            this.Status2.Name = "Status2";
            this.Status2.Width = 50;
            // 
            // Status1
            // 
            this.Status1.DataPropertyName = "Status1";
            this.Status1.HeaderText = "STATUS (1)";
            this.Status1.Name = "Status1";
            this.Status1.Width = 50;
            // 
            // Data2
            // 
            this.Data2.DataPropertyName = "Inicio2";
            this.Data2.HeaderText = "DATA INÍCIO (2)";
            this.Data2.Name = "Data2";
            // 
            // Data1
            // 
            this.Data1.DataPropertyName = "Inicio1";
            this.Data1.HeaderText = "DATA INÍCIO (1)";
            this.Data1.Name = "Data1";
            // 
            // Cursos2
            // 
            this.Cursos2.DataPropertyName = "Curso2";
            this.Cursos2.HeaderText = "CURSOS (2)";
            this.Cursos2.Name = "Cursos2";
            this.Cursos2.Width = 80;
            // 
            // Curso1
            // 
            this.Curso1.DataPropertyName = "Curso1";
            this.Curso1.HeaderText = "CURSOS (1)";
            this.Curso1.Name = "Curso1";
            this.Curso1.Width = 80;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.Width = 120;
            // 
            // RA
            // 
            this.RA.DataPropertyName = "RA";
            this.RA.HeaderText = "RA MATRICULA";
            this.RA.Name = "RA";
            this.RA.Width = 50;
            // 
            // dgv_MatAlunos
            // 
            this.dgv_MatAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MatAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RA,
            this.Nome,
            this.Curso1,
            this.Cursos2,
            this.Data1,
            this.Data2,
            this.Status1,
            this.Status2});
            this.dgv_MatAlunos.Location = new System.Drawing.Point(12, 46);
            this.dgv_MatAlunos.Name = "dgv_MatAlunos";
            this.dgv_MatAlunos.Size = new System.Drawing.Size(674, 177);
            this.dgv_MatAlunos.TabIndex = 18;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.dgv_MatAlunos);
            this.Name = "FrmConsulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        public System.Windows.Forms.DataGridView dgv_MatAlunos;
    }
}