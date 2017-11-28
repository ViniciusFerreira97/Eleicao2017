namespace Eleicoes
{
    partial class FrmExcluir
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
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rbnVereador = new System.Windows.Forms.RadioButton();
            this.rbnPrefeito = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnUrna);
            this.groupBox1.Controls.Add(this.rbnEleitores);
            this.groupBox1.Controls.Add(this.rbnCandidato);
            this.groupBox1.Controls.Add(this.rbnPartido);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 55);
            this.groupBox1.TabIndex = 1;
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
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(5, 102);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(116, 20);
            this.txtExcluir.TabIndex = 2;
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Location = new System.Drawing.Point(5, 83);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(44, 13);
            this.lblExcluir.TabIndex = 3;
            this.lblExcluir.Text = "Número";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(139, 245);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(182, 37);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rbnVereador);
            this.grpTipo.Controls.Add(this.rbnPrefeito);
            this.grpTipo.Location = new System.Drawing.Point(0, 159);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(248, 54);
            this.grpTipo.TabIndex = 14;
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
            // 
            // FrmExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 294);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExcluir";
            this.Text = "FrmExcluir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExcluir_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnUrna;
        private System.Windows.Forms.RadioButton rbnEleitores;
        private System.Windows.Forms.RadioButton rbnCandidato;
        private System.Windows.Forms.RadioButton rbnPartido;
        private System.Windows.Forms.TextBox txtExcluir;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rbnVereador;
        private System.Windows.Forms.RadioButton rbnPrefeito;
    }
}