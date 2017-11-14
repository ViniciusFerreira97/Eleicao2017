namespace Eleicoes
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnPartido = new System.Windows.Forms.RadioButton();
            this.rbnCandidato = new System.Windows.Forms.RadioButton();
            this.rbnEleitores = new System.Windows.Forms.RadioButton();
            this.rbnUrna = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblDat = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.lblCodgo = new System.Windows.Forms.Label();
            this.txtVariavel1 = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.txtVariavel2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtVariavel3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnUrna);
            this.groupBox1.Controls.Add(this.rbnEleitores);
            this.groupBox1.Controls.Add(this.rbnCandidato);
            this.groupBox1.Controls.Add(this.rbnPartido);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // rbnPartido
            // 
            this.rbnPartido.AutoSize = true;
            this.rbnPartido.Location = new System.Drawing.Point(7, 20);
            this.rbnPartido.Name = "rbnPartido";
            this.rbnPartido.Size = new System.Drawing.Size(58, 17);
            this.rbnPartido.TabIndex = 0;
            this.rbnPartido.TabStop = true;
            this.rbnPartido.Text = "Partido";
            this.rbnPartido.UseVisualStyleBackColor = true;
            this.rbnPartido.CheckedChanged += new System.EventHandler(this.rbnPartido_CheckedChanged);
            // 
            // rbnCandidato
            // 
            this.rbnCandidato.AutoSize = true;
            this.rbnCandidato.Location = new System.Drawing.Point(87, 20);
            this.rbnCandidato.Name = "rbnCandidato";
            this.rbnCandidato.Size = new System.Drawing.Size(73, 17);
            this.rbnCandidato.TabIndex = 1;
            this.rbnCandidato.TabStop = true;
            this.rbnCandidato.Text = "Candidato";
            this.rbnCandidato.UseVisualStyleBackColor = true;
            this.rbnCandidato.CheckedChanged += new System.EventHandler(this.rbnCandidato_CheckedChanged);
            // 
            // rbnEleitores
            // 
            this.rbnEleitores.AutoSize = true;
            this.rbnEleitores.Location = new System.Drawing.Point(186, 20);
            this.rbnEleitores.Name = "rbnEleitores";
            this.rbnEleitores.Size = new System.Drawing.Size(65, 17);
            this.rbnEleitores.TabIndex = 2;
            this.rbnEleitores.TabStop = true;
            this.rbnEleitores.Text = "Eleitores";
            this.rbnEleitores.UseVisualStyleBackColor = true;
            this.rbnEleitores.CheckedChanged += new System.EventHandler(this.rbnEleitores_CheckedChanged);
            // 
            // rbnUrna
            // 
            this.rbnUrna.AutoSize = true;
            this.rbnUrna.Location = new System.Drawing.Point(268, 20);
            this.rbnUrna.Name = "rbnUrna";
            this.rbnUrna.Size = new System.Drawing.Size(48, 17);
            this.rbnUrna.TabIndex = 3;
            this.rbnUrna.TabStop = true;
            this.rbnUrna.Text = "Urna";
            this.rbnUrna.UseVisualStyleBackColor = true;
            this.rbnUrna.CheckedChanged += new System.EventHandler(this.rbnUrna_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(77, 263);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(95, 32);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(181, 263);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 32);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir ";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Location = new System.Drawing.Point(163, 84);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(104, 13);
            this.lblDat.TabIndex = 6;
            this.lblDat.Text = "Data de Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(163, 103);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // lblCodgo
            // 
            this.lblCodgo.AutoSize = true;
            this.lblCodgo.Location = new System.Drawing.Point(12, 139);
            this.lblCodgo.Name = "lblCodgo";
            this.lblCodgo.Size = new System.Drawing.Size(40, 13);
            this.lblCodgo.TabIndex = 8;
            this.lblCodgo.Text = "Código";
            // 
            // txtVariavel1
            // 
            this.txtVariavel1.Location = new System.Drawing.Point(12, 158);
            this.txtVariavel1.Name = "txtVariavel1";
            this.txtVariavel1.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel1.TabIndex = 7;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(163, 139);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(40, 13);
            this.lblPartido.TabIndex = 10;
            this.lblPartido.Text = "Partido";
            // 
            // txtVariavel2
            // 
            this.txtVariavel2.Location = new System.Drawing.Point(163, 158);
            this.txtVariavel2.Name = "txtVariavel2";
            this.txtVariavel2.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel2.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail";
            // 
            // txtVariavel3
            // 
            this.txtVariavel3.Location = new System.Drawing.Point(12, 209);
            this.txtVariavel3.Name = "txtVariavel3";
            this.txtVariavel3.Size = new System.Drawing.Size(251, 20);
            this.txtVariavel3.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 307);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtVariavel3);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.txtVariavel2);
            this.Controls.Add(this.lblCodgo);
            this.Controls.Add(this.txtVariavel1);
            this.Controls.Add(this.lblDat);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnUrna;
        private System.Windows.Forms.RadioButton rbnEleitores;
        private System.Windows.Forms.RadioButton rbnCandidato;
        private System.Windows.Forms.RadioButton rbnPartido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label lblCodgo;
        private System.Windows.Forms.TextBox txtVariavel1;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.TextBox txtVariavel2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtVariavel3;
    }
}