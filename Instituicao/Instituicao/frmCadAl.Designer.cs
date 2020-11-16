namespace Instituicao
{
    partial class frmCadAl
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
            this.txt_RA = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_1Curso = new System.Windows.Forms.ComboBox();
            this.txt_2Curso = new System.Windows.Forms.ComboBox();
            this.data_1Curso = new System.Windows.Forms.DateTimePicker();
            this.data_2Curso = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.txt_Sts1 = new System.Windows.Forms.ComboBox();
            this.txt_Sts2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_RA
            // 
            this.txt_RA.Location = new System.Drawing.Point(70, 39);
            this.txt_RA.Name = "txt_RA";
            this.txt_RA.Size = new System.Drawing.Size(32, 20);
            this.txt_RA.TabIndex = 0;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(146, 39);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(236, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_1Curso
            // 
            this.txt_1Curso.FormattingEnabled = true;
            this.txt_1Curso.Items.AddRange(new object[] {
            "Matemática",
            "Português",
            "Informática",
            "Inglês"});
            this.txt_1Curso.Location = new System.Drawing.Point(101, 124);
            this.txt_1Curso.Name = "txt_1Curso";
            this.txt_1Curso.Size = new System.Drawing.Size(108, 21);
            this.txt_1Curso.TabIndex = 2;
            // 
            // txt_2Curso
            // 
            this.txt_2Curso.FormattingEnabled = true;
            this.txt_2Curso.Items.AddRange(new object[] {
            "Matemática",
            "Português",
            "Informática",
            "Inglês"});
            this.txt_2Curso.Location = new System.Drawing.Point(101, 171);
            this.txt_2Curso.Name = "txt_2Curso";
            this.txt_2Curso.Size = new System.Drawing.Size(108, 21);
            this.txt_2Curso.TabIndex = 3;
            // 
            // data_1Curso
            // 
            this.data_1Curso.Location = new System.Drawing.Point(271, 125);
            this.data_1Curso.MaxDate = new System.DateTime(2020, 12, 20, 0, 0, 0, 0);
            this.data_1Curso.MinDate = new System.DateTime(2020, 2, 1, 0, 0, 0, 0);
            this.data_1Curso.Name = "data_1Curso";
            this.data_1Curso.Size = new System.Drawing.Size(144, 20);
            this.data_1Curso.TabIndex = 4;
            this.data_1Curso.Value = new System.DateTime(2020, 2, 3, 0, 0, 0, 0);
            // 
            // data_2Curso
            // 
            this.data_2Curso.Location = new System.Drawing.Point(271, 173);
            this.data_2Curso.MaxDate = new System.DateTime(2020, 12, 20, 0, 0, 0, 0);
            this.data_2Curso.MinDate = new System.DateTime(2020, 2, 1, 0, 0, 0, 0);
            this.data_2Curso.Name = "data_2Curso";
            this.data_2Curso.Size = new System.Drawing.Size(144, 20);
            this.data_2Curso.TabIndex = 5;
            this.data_2Curso.Value = new System.DateTime(2020, 2, 3, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "RA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "1 Opção de Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "2 Opção de Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inicio";
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.Location = new System.Drawing.Point(196, 230);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(82, 28);
            this.btn_Cadastro.TabIndex = 12;
            this.btn_Cadastro.Text = "Cadastrar";
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // txt_Sts1
            // 
            this.txt_Sts1.FormattingEnabled = true;
            this.txt_Sts1.Items.AddRange(new object[] {
            "Concluído",
            "Cursando",
            "Não Concluído"});
            this.txt_Sts1.Location = new System.Drawing.Point(487, 125);
            this.txt_Sts1.Name = "txt_Sts1";
            this.txt_Sts1.Size = new System.Drawing.Size(74, 21);
            this.txt_Sts1.TabIndex = 13;
            // 
            // txt_Sts2
            // 
            this.txt_Sts2.FormattingEnabled = true;
            this.txt_Sts2.Items.AddRange(new object[] {
            "Concluído",
            "Cursando",
            "Não Concluído"});
            this.txt_Sts2.Location = new System.Drawing.Point(487, 174);
            this.txt_Sts2.Name = "txt_Sts2";
            this.txt_Sts2.Size = new System.Drawing.Size(74, 21);
            this.txt_Sts2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Status";
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(106, 230);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(82, 28);
            this.btn_Novo.TabIndex = 18;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(284, 230);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(82, 28);
            this.btn_Consultar.TabIndex = 19;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(372, 230);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(82, 28);
            this.btn_Sair.TabIndex = 20;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frmCadAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 276);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Sts2);
            this.Controls.Add(this.txt_Sts1);
            this.Controls.Add(this.btn_Cadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_2Curso);
            this.Controls.Add(this.data_1Curso);
            this.Controls.Add(this.txt_2Curso);
            this.Controls.Add(this.txt_1Curso);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_RA);
            this.Name = "frmCadAl";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_RA;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.ComboBox txt_1Curso;
        private System.Windows.Forms.ComboBox txt_2Curso;
        private System.Windows.Forms.DateTimePicker data_1Curso;
        private System.Windows.Forms.DateTimePicker data_2Curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.ComboBox txt_Sts1;
        private System.Windows.Forms.ComboBox txt_Sts2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Sair;
    }
}