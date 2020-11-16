namespace Instituicao
{
    partial class frm_Aluno
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_BuscarAluno = new System.Windows.Forms.Button();
            this.dgv_MatAlunos = new System.Windows.Forms.DataGridView();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "R.A:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_BuscarAluno
            // 
            this.btn_BuscarAluno.Location = new System.Drawing.Point(424, 34);
            this.btn_BuscarAluno.Name = "btn_BuscarAluno";
            this.btn_BuscarAluno.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarAluno.TabIndex = 2;
            this.btn_BuscarAluno.Text = "Buscar";
            this.btn_BuscarAluno.UseVisualStyleBackColor = true;
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
            this.dgv_MatAlunos.Location = new System.Drawing.Point(12, 76);
            this.dgv_MatAlunos.Name = "dgv_MatAlunos";
            this.dgv_MatAlunos.Size = new System.Drawing.Size(868, 177);
            this.dgv_MatAlunos.TabIndex = 19;
            // 
            // RA
            // 
            this.RA.DataPropertyName = "RA";
            this.RA.HeaderText = "RA MATRICULA";
            this.RA.Name = "RA";
            this.RA.Width = 80;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // Curso1
            // 
            this.Curso1.DataPropertyName = "Curso1";
            this.Curso1.HeaderText = "CURSOS (1)";
            this.Curso1.Name = "Curso1";
            // 
            // Cursos2
            // 
            this.Cursos2.DataPropertyName = "Curso2";
            this.Cursos2.HeaderText = "CURSOS (2)";
            this.Cursos2.Name = "Cursos2";
            // 
            // Data1
            // 
            this.Data1.DataPropertyName = "Inicio1";
            this.Data1.HeaderText = "DATA INÍCIO (1)";
            this.Data1.Name = "Data1";
            // 
            // Data2
            // 
            this.Data2.DataPropertyName = "Inicio2";
            this.Data2.HeaderText = "DATA INÍCIO (2)";
            this.Data2.Name = "Data2";
            // 
            // Status1
            // 
            this.Status1.DataPropertyName = "Status1";
            this.Status1.HeaderText = "STATUS (1)";
            this.Status1.Name = "Status1";
            // 
            // Status2
            // 
            this.Status2.DataPropertyName = "Status2";
            this.Status2.HeaderText = "STATUS (2)";
            this.Status2.Name = "Status2";
            // 
            // frm_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 299);
            this.Controls.Add(this.dgv_MatAlunos);
            this.Controls.Add(this.btn_BuscarAluno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Aluno";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_BuscarAluno;
        public System.Windows.Forms.DataGridView dgv_MatAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status2;
    }
}