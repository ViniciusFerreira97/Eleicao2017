﻿namespace Eleicoes
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
            this.rbnUrna = new System.Windows.Forms.RadioButton();
            this.rbnEleitores = new System.Windows.Forms.RadioButton();
            this.rbnCandidato = new System.Windows.Forms.RadioButton();
            this.rbnPartido = new System.Windows.Forms.RadioButton();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnPrefeito = new System.Windows.Forms.RadioButton();
            this.rbnVereador = new System.Windows.Forms.RadioButton();
            this.lclEmailVice = new System.Windows.Forms.Label();
            this.txtEmailVice = new System.Windows.Forms.TextBox();
            this.lblPartidoVice = new System.Windows.Forms.Label();
            this.txtPartidoVice = new System.Windows.Forms.TextBox();
            this.lblCodVice = new System.Windows.Forms.Label();
            this.txtCodVice = new System.Windows.Forms.TextBox();
            this.lblDatVice = new System.Windows.Forms.Label();
            this.txtDatVice = new System.Windows.Forms.TextBox();
            this.lblNomeVice = new System.Windows.Forms.Label();
            this.txtNomeVice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(460, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // rbnUrna
            // 
            this.rbnUrna.AutoSize = true;
            this.rbnUrna.Location = new System.Drawing.Point(381, 20);
            this.rbnUrna.Name = "rbnUrna";
            this.rbnUrna.Size = new System.Drawing.Size(48, 17);
            this.rbnUrna.TabIndex = 3;
            this.rbnUrna.Text = "Urna";
            this.rbnUrna.UseVisualStyleBackColor = true;
            this.rbnUrna.CheckedChanged += new System.EventHandler(this.rbnUrna_CheckedChanged);
            // 
            // rbnEleitores
            // 
            this.rbnEleitores.AutoSize = true;
            this.rbnEleitores.Location = new System.Drawing.Point(256, 20);
            this.rbnEleitores.Name = "rbnEleitores";
            this.rbnEleitores.Size = new System.Drawing.Size(65, 17);
            this.rbnEleitores.TabIndex = 2;
            this.rbnEleitores.Text = "Eleitores";
            this.rbnEleitores.UseVisualStyleBackColor = true;
            this.rbnEleitores.CheckedChanged += new System.EventHandler(this.rbnEleitores_CheckedChanged);
            // 
            // rbnCandidato
            // 
            this.rbnCandidato.AutoSize = true;
            this.rbnCandidato.Location = new System.Drawing.Point(119, 20);
            this.rbnCandidato.Name = "rbnCandidato";
            this.rbnCandidato.Size = new System.Drawing.Size(73, 17);
            this.rbnCandidato.TabIndex = 1;
            this.rbnCandidato.Text = "Candidato";
            this.rbnCandidato.UseVisualStyleBackColor = true;
            this.rbnCandidato.CheckedChanged += new System.EventHandler(this.rbnCandidato_CheckedChanged);
            // 
            // rbnPartido
            // 
            this.rbnPartido.AutoSize = true;
            this.rbnPartido.Checked = true;
            this.rbnPartido.Location = new System.Drawing.Point(7, 20);
            this.rbnPartido.Name = "rbnPartido";
            this.rbnPartido.Size = new System.Drawing.Size(58, 17);
            this.rbnPartido.TabIndex = 0;
            this.rbnPartido.TabStop = true;
            this.rbnPartido.Text = "Partido";
            this.rbnPartido.UseVisualStyleBackColor = true;
            this.rbnPartido.CheckedChanged += new System.EventHandler(this.rbnPartido_CheckedChanged);
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
            this.btnCadastrar.Location = new System.Drawing.Point(121, 348);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(95, 32);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(256, 348);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 32);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir ";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Location = new System.Drawing.Point(131, 84);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(104, 13);
            this.lblDat.TabIndex = 6;
            this.lblDat.Text = "Data de Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(131, 103);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // lblCodgo
            // 
            this.lblCodgo.AutoSize = true;
            this.lblCodgo.Location = new System.Drawing.Point(252, 84);
            this.lblCodgo.Name = "lblCodgo";
            this.lblCodgo.Size = new System.Drawing.Size(40, 13);
            this.lblCodgo.TabIndex = 8;
            this.lblCodgo.Text = "Código";
            // 
            // txtVariavel1
            // 
            this.txtVariavel1.Location = new System.Drawing.Point(251, 103);
            this.txtVariavel1.Name = "txtVariavel1";
            this.txtVariavel1.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel1.TabIndex = 7;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(372, 84);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(40, 13);
            this.lblPartido.TabIndex = 10;
            this.lblPartido.Text = "Partido";
            // 
            // txtVariavel2
            // 
            this.txtVariavel2.Location = new System.Drawing.Point(372, 103);
            this.txtVariavel2.Name = "txtVariavel2";
            this.txtVariavel2.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel2.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail";
            // 
            // txtVariavel3
            // 
            this.txtVariavel3.Location = new System.Drawing.Point(9, 145);
            this.txtVariavel3.Name = "txtVariavel3";
            this.txtVariavel3.Size = new System.Drawing.Size(342, 20);
            this.txtVariavel3.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnVereador);
            this.groupBox2.Controls.Add(this.rbnPrefeito);
            this.groupBox2.Location = new System.Drawing.Point(9, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 54);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Candidato";
            // 
            // rbnPrefeito
            // 
            this.rbnPrefeito.AutoSize = true;
            this.rbnPrefeito.Location = new System.Drawing.Point(7, 20);
            this.rbnPrefeito.Name = "rbnPrefeito";
            this.rbnPrefeito.Size = new System.Drawing.Size(132, 17);
            this.rbnPrefeito.TabIndex = 0;
            this.rbnPrefeito.TabStop = true;
            this.rbnPrefeito.Text = "Prefeito / Vice Prefeito";
            this.rbnPrefeito.UseVisualStyleBackColor = true;
            // 
            // rbnVereador
            // 
            this.rbnVereador.AutoSize = true;
            this.rbnVereador.Location = new System.Drawing.Point(174, 20);
            this.rbnVereador.Name = "rbnVereador";
            this.rbnVereador.Size = new System.Drawing.Size(68, 17);
            this.rbnVereador.TabIndex = 2;
            this.rbnVereador.TabStop = true;
            this.rbnVereador.Text = "Vereador";
            this.rbnVereador.UseVisualStyleBackColor = true;
            // 
            // lclEmailVice
            // 
            this.lclEmailVice.AutoSize = true;
            this.lclEmailVice.Location = new System.Drawing.Point(9, 293);
            this.lclEmailVice.Name = "lclEmailVice";
            this.lclEmailVice.Size = new System.Drawing.Size(35, 13);
            this.lclEmailVice.TabIndex = 23;
            this.lclEmailVice.Text = "E-mail";
            // 
            // txtEmailVice
            // 
            this.txtEmailVice.Location = new System.Drawing.Point(9, 312);
            this.txtEmailVice.Name = "txtEmailVice";
            this.txtEmailVice.Size = new System.Drawing.Size(342, 20);
            this.txtEmailVice.TabIndex = 22;
            // 
            // lblPartidoVice
            // 
            this.lblPartidoVice.AutoSize = true;
            this.lblPartidoVice.Location = new System.Drawing.Point(372, 248);
            this.lblPartidoVice.Name = "lblPartidoVice";
            this.lblPartidoVice.Size = new System.Drawing.Size(40, 13);
            this.lblPartidoVice.TabIndex = 21;
            this.lblPartidoVice.Text = "Partido";
            // 
            // txtPartidoVice
            // 
            this.txtPartidoVice.Location = new System.Drawing.Point(372, 267);
            this.txtPartidoVice.Name = "txtPartidoVice";
            this.txtPartidoVice.Size = new System.Drawing.Size(100, 20);
            this.txtPartidoVice.TabIndex = 20;
            // 
            // lblCodVice
            // 
            this.lblCodVice.AutoSize = true;
            this.lblCodVice.Location = new System.Drawing.Point(251, 248);
            this.lblCodVice.Name = "lblCodVice";
            this.lblCodVice.Size = new System.Drawing.Size(40, 13);
            this.lblCodVice.TabIndex = 19;
            this.lblCodVice.Text = "Código";
            // 
            // txtCodVice
            // 
            this.txtCodVice.Location = new System.Drawing.Point(251, 267);
            this.txtCodVice.Name = "txtCodVice";
            this.txtCodVice.Size = new System.Drawing.Size(100, 20);
            this.txtCodVice.TabIndex = 18;
            // 
            // lblDatVice
            // 
            this.lblDatVice.AutoSize = true;
            this.lblDatVice.Location = new System.Drawing.Point(131, 248);
            this.lblDatVice.Name = "lblDatVice";
            this.lblDatVice.Size = new System.Drawing.Size(104, 13);
            this.lblDatVice.TabIndex = 17;
            this.lblDatVice.Text = "Data de Nascimento";
            // 
            // txtDatVice
            // 
            this.txtDatVice.Location = new System.Drawing.Point(131, 267);
            this.txtDatVice.Name = "txtDatVice";
            this.txtDatVice.Size = new System.Drawing.Size(100, 20);
            this.txtDatVice.TabIndex = 16;
            // 
            // lblNomeVice
            // 
            this.lblNomeVice.AutoSize = true;
            this.lblNomeVice.Location = new System.Drawing.Point(9, 248);
            this.lblNomeVice.Name = "lblNomeVice";
            this.lblNomeVice.Size = new System.Drawing.Size(38, 13);
            this.lblNomeVice.TabIndex = 15;
            this.lblNomeVice.Text = "Nome ";
            // 
            // txtNomeVice
            // 
            this.txtNomeVice.Location = new System.Drawing.Point(9, 267);
            this.txtNomeVice.Name = "txtNomeVice";
            this.txtNomeVice.Size = new System.Drawing.Size(100, 20);
            this.txtNomeVice.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 389);
            this.Controls.Add(this.lclEmailVice);
            this.Controls.Add(this.txtEmailVice);
            this.Controls.Add(this.lblPartidoVice);
            this.Controls.Add(this.txtPartidoVice);
            this.Controls.Add(this.lblCodVice);
            this.Controls.Add(this.txtCodVice);
            this.Controls.Add(this.lblDatVice);
            this.Controls.Add(this.txtDatVice);
            this.Controls.Add(this.lblNomeVice);
            this.Controls.Add(this.txtNomeVice);
            this.Controls.Add(this.groupBox2);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnVereador;
        private System.Windows.Forms.RadioButton rbnPrefeito;
        private System.Windows.Forms.Label lclEmailVice;
        private System.Windows.Forms.TextBox txtEmailVice;
        private System.Windows.Forms.Label lblPartidoVice;
        private System.Windows.Forms.TextBox txtPartidoVice;
        private System.Windows.Forms.Label lblCodVice;
        private System.Windows.Forms.TextBox txtCodVice;
        private System.Windows.Forms.Label lblDatVice;
        private System.Windows.Forms.TextBox txtDatVice;
        private System.Windows.Forms.Label lblNomeVice;
        private System.Windows.Forms.TextBox txtNomeVice;
    }
}