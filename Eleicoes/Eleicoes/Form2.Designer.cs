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
            this.rbnUrna = new System.Windows.Forms.RadioButton();
            this.rbnEleitores = new System.Windows.Forms.RadioButton();
            this.rbnCandidato = new System.Windows.Forms.RadioButton();
            this.rbnPartido = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblDat = new System.Windows.Forms.Label();
            this.lblCodgo = new System.Windows.Forms.Label();
            this.txtVariavel1 = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtVariavel3 = new System.Windows.Forms.TextBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rbnVereador = new System.Windows.Forms.RadioButton();
            this.rbnPrefeito = new System.Windows.Forms.RadioButton();
            this.lclEmailVice = new System.Windows.Forms.Label();
            this.txtEmailVice = new System.Windows.Forms.TextBox();
            this.lblPartidoVice = new System.Windows.Forms.Label();
            this.txtPartidoVice = new System.Windows.Forms.TextBox();
            this.lblCodVice = new System.Windows.Forms.Label();
            this.txtCodVice = new System.Windows.Forms.TextBox();
            this.lblDatVice = new System.Windows.Forms.Label();
            this.lblNomeVice = new System.Windows.Forms.Label();
            this.txtNomeVice = new System.Windows.Forms.TextBox();
            this.cbxPartido = new System.Windows.Forms.ComboBox();
            this.txtVariavel2 = new System.Windows.Forms.TextBox();
            this.grpVice = new System.Windows.Forms.GroupBox();
            this.txtDatVice = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.ckbExcluir = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.grpVice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnUrna);
            this.groupBox1.Controls.Add(this.rbnEleitores);
            this.groupBox1.Controls.Add(this.rbnCandidato);
            this.groupBox1.Controls.Add(this.rbnPartido);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
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
            this.txtNome.Location = new System.Drawing.Point(12, 136);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 117);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(121, 398);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(95, 32);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(256, 398);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 32);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir ";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Location = new System.Drawing.Point(131, 117);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(104, 13);
            this.lblDat.TabIndex = 6;
            this.lblDat.Text = "Data de Nascimento";
            // 
            // lblCodgo
            // 
            this.lblCodgo.AutoSize = true;
            this.lblCodgo.Location = new System.Drawing.Point(252, 117);
            this.lblCodgo.Name = "lblCodgo";
            this.lblCodgo.Size = new System.Drawing.Size(40, 13);
            this.lblCodgo.TabIndex = 8;
            this.lblCodgo.Text = "Código";
            // 
            // txtVariavel1
            // 
            this.txtVariavel1.Location = new System.Drawing.Point(251, 136);
            this.txtVariavel1.Name = "txtVariavel1";
            this.txtVariavel1.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel1.TabIndex = 7;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(372, 117);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(40, 13);
            this.lblPartido.TabIndex = 10;
            this.lblPartido.Text = "Partido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail";
            // 
            // txtVariavel3
            // 
            this.txtVariavel3.Location = new System.Drawing.Point(9, 178);
            this.txtVariavel3.Name = "txtVariavel3";
            this.txtVariavel3.Size = new System.Drawing.Size(342, 20);
            this.txtVariavel3.TabIndex = 11;
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rbnVereador);
            this.grpTipo.Controls.Add(this.rbnPrefeito);
            this.grpTipo.Location = new System.Drawing.Point(9, 204);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(248, 54);
            this.grpTipo.TabIndex = 13;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo Candidato";
            // 
            // rbnVereador
            // 
            this.rbnVereador.AutoSize = true;
            this.rbnVereador.Checked = true;
            this.rbnVereador.Location = new System.Drawing.Point(174, 20);
            this.rbnVereador.Name = "rbnVereador";
            this.rbnVereador.Size = new System.Drawing.Size(68, 17);
            this.rbnVereador.TabIndex = 2;
            this.rbnVereador.TabStop = true;
            this.rbnVereador.Text = "Vereador";
            this.rbnVereador.UseVisualStyleBackColor = true;
            this.rbnVereador.CheckedChanged += new System.EventHandler(this.rbnVereador_CheckedChanged);
            // 
            // rbnPrefeito
            // 
            this.rbnPrefeito.AutoSize = true;
            this.rbnPrefeito.Location = new System.Drawing.Point(7, 20);
            this.rbnPrefeito.Name = "rbnPrefeito";
            this.rbnPrefeito.Size = new System.Drawing.Size(132, 17);
            this.rbnPrefeito.TabIndex = 0;
            this.rbnPrefeito.Text = "Prefeito / Vice Prefeito";
            this.rbnPrefeito.UseVisualStyleBackColor = true;
            this.rbnPrefeito.CheckedChanged += new System.EventHandler(this.rbnPrefeito_CheckedChanged);
            // 
            // lclEmailVice
            // 
            this.lclEmailVice.AutoSize = true;
            this.lclEmailVice.Location = new System.Drawing.Point(2, 54);
            this.lclEmailVice.Name = "lclEmailVice";
            this.lclEmailVice.Size = new System.Drawing.Size(35, 13);
            this.lclEmailVice.TabIndex = 23;
            this.lclEmailVice.Text = "E-mail";
            // 
            // txtEmailVice
            // 
            this.txtEmailVice.Location = new System.Drawing.Point(5, 77);
            this.txtEmailVice.Name = "txtEmailVice";
            this.txtEmailVice.Size = new System.Drawing.Size(342, 20);
            this.txtEmailVice.TabIndex = 22;
            // 
            // lblPartidoVice
            // 
            this.lblPartidoVice.AutoSize = true;
            this.lblPartidoVice.Location = new System.Drawing.Point(365, 9);
            this.lblPartidoVice.Name = "lblPartidoVice";
            this.lblPartidoVice.Size = new System.Drawing.Size(40, 13);
            this.lblPartidoVice.TabIndex = 21;
            this.lblPartidoVice.Text = "Partido";
            // 
            // txtPartidoVice
            // 
            this.txtPartidoVice.Location = new System.Drawing.Point(365, 28);
            this.txtPartidoVice.Name = "txtPartidoVice";
            this.txtPartidoVice.Size = new System.Drawing.Size(100, 20);
            this.txtPartidoVice.TabIndex = 20;
            // 
            // lblCodVice
            // 
            this.lblCodVice.AutoSize = true;
            this.lblCodVice.Location = new System.Drawing.Point(244, 9);
            this.lblCodVice.Name = "lblCodVice";
            this.lblCodVice.Size = new System.Drawing.Size(40, 13);
            this.lblCodVice.TabIndex = 19;
            this.lblCodVice.Text = "Código";
            // 
            // txtCodVice
            // 
            this.txtCodVice.Location = new System.Drawing.Point(244, 28);
            this.txtCodVice.Name = "txtCodVice";
            this.txtCodVice.Size = new System.Drawing.Size(100, 20);
            this.txtCodVice.TabIndex = 18;
            // 
            // lblDatVice
            // 
            this.lblDatVice.AutoSize = true;
            this.lblDatVice.Location = new System.Drawing.Point(124, 9);
            this.lblDatVice.Name = "lblDatVice";
            this.lblDatVice.Size = new System.Drawing.Size(104, 13);
            this.lblDatVice.TabIndex = 17;
            this.lblDatVice.Text = "Data de Nascimento";
            // 
            // lblNomeVice
            // 
            this.lblNomeVice.AutoSize = true;
            this.lblNomeVice.Location = new System.Drawing.Point(2, 9);
            this.lblNomeVice.Name = "lblNomeVice";
            this.lblNomeVice.Size = new System.Drawing.Size(38, 13);
            this.lblNomeVice.TabIndex = 15;
            this.lblNomeVice.Text = "Nome ";
            // 
            // txtNomeVice
            // 
            this.txtNomeVice.Location = new System.Drawing.Point(2, 28);
            this.txtNomeVice.Name = "txtNomeVice";
            this.txtNomeVice.Size = new System.Drawing.Size(100, 20);
            this.txtNomeVice.TabIndex = 14;
            // 
            // cbxPartido
            // 
            this.cbxPartido.FormattingEnabled = true;
            this.cbxPartido.Location = new System.Drawing.Point(375, 135);
            this.cbxPartido.Name = "cbxPartido";
            this.cbxPartido.Size = new System.Drawing.Size(107, 21);
            this.cbxPartido.TabIndex = 24;
            this.cbxPartido.Text = "SELECIONAR";
            // 
            // txtVariavel2
            // 
            this.txtVariavel2.Location = new System.Drawing.Point(377, 134);
            this.txtVariavel2.Name = "txtVariavel2";
            this.txtVariavel2.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel2.TabIndex = 25;
            // 
            // grpVice
            // 
            this.grpVice.Controls.Add(this.txtDatVice);
            this.grpVice.Controls.Add(this.txtCodVice);
            this.grpVice.Controls.Add(this.txtEmailVice);
            this.grpVice.Controls.Add(this.lclEmailVice);
            this.grpVice.Controls.Add(this.lblPartidoVice);
            this.grpVice.Controls.Add(this.txtPartidoVice);
            this.grpVice.Controls.Add(this.lblCodVice);
            this.grpVice.Controls.Add(this.lblDatVice);
            this.grpVice.Controls.Add(this.lblNomeVice);
            this.grpVice.Controls.Add(this.txtNomeVice);
            this.grpVice.Location = new System.Drawing.Point(-1, 289);
            this.grpVice.Name = "grpVice";
            this.grpVice.Size = new System.Drawing.Size(483, 103);
            this.grpVice.TabIndex = 26;
            this.grpVice.TabStop = false;
            // 
            // txtDatVice
            // 
            this.txtDatVice.Location = new System.Drawing.Point(127, 28);
            this.txtDatVice.Mask = "00/00/0000";
            this.txtDatVice.Name = "txtDatVice";
            this.txtDatVice.Size = new System.Drawing.Size(100, 20);
            this.txtDatVice.TabIndex = 28;
            this.txtDatVice.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Dados Vice Prefeito";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(134, 136);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 28;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // ckbExcluir
            // 
            this.ckbExcluir.AutoSize = true;
            this.ckbExcluir.Location = new System.Drawing.Point(177, 12);
            this.ckbExcluir.Name = "ckbExcluir";
            this.ckbExcluir.Size = new System.Drawing.Size(57, 17);
            this.ckbExcluir.TabIndex = 29;
            this.ckbExcluir.Text = "Excluir";
            this.ckbExcluir.UseVisualStyleBackColor = true;
            this.ckbExcluir.CheckedChanged += new System.EventHandler(this.ckbExcluir_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 437);
            this.Controls.Add(this.ckbExcluir);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPartido);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtVariavel3);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblCodgo);
            this.Controls.Add(this.txtVariavel1);
            this.Controls.Add(this.lblDat);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVariavel2);
            this.Controls.Add(this.grpVice);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpVice.ResumeLayout(false);
            this.grpVice.PerformLayout();
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
        private System.Windows.Forms.Label lblCodgo;
        private System.Windows.Forms.TextBox txtVariavel1;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtVariavel3;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rbnVereador;
        private System.Windows.Forms.RadioButton rbnPrefeito;
        private System.Windows.Forms.Label lclEmailVice;
        private System.Windows.Forms.TextBox txtEmailVice;
        private System.Windows.Forms.Label lblPartidoVice;
        private System.Windows.Forms.TextBox txtPartidoVice;
        private System.Windows.Forms.Label lblCodVice;
        private System.Windows.Forms.TextBox txtCodVice;
        private System.Windows.Forms.Label lblDatVice;
        private System.Windows.Forms.Label lblNomeVice;
        private System.Windows.Forms.TextBox txtNomeVice;
        private System.Windows.Forms.ComboBox cbxPartido;
        private System.Windows.Forms.TextBox txtVariavel2;
        private System.Windows.Forms.GroupBox grpVice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDatVice;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.CheckBox ckbExcluir;
    }
}