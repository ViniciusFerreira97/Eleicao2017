namespace Eleicoes
{
    partial class FormFinalizador
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
            this.gpGanhadores = new System.Windows.Forms.GroupBox();
            this.lblPartido2 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblCod2 = new System.Windows.Forms.Label();
            this.lblPartido1 = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblCod1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblPrefeito = new System.Windows.Forms.Label();
            this.lstVereadores = new System.Windows.Forms.ListBox();
            this.btnFim = new System.Windows.Forms.Button();
            this.gpGanhadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpGanhadores
            // 
            this.gpGanhadores.Controls.Add(this.lblPartido2);
            this.gpGanhadores.Controls.Add(this.lblNome2);
            this.gpGanhadores.Controls.Add(this.lblCod2);
            this.gpGanhadores.Controls.Add(this.lblPartido1);
            this.gpGanhadores.Controls.Add(this.lblNome1);
            this.gpGanhadores.Controls.Add(this.lblCod1);
            this.gpGanhadores.Controls.Add(this.lblX);
            this.gpGanhadores.Controls.Add(this.lblPrefeito);
            this.gpGanhadores.Controls.Add(this.lstVereadores);
            this.gpGanhadores.Location = new System.Drawing.Point(12, 12);
            this.gpGanhadores.Name = "gpGanhadores";
            this.gpGanhadores.Size = new System.Drawing.Size(648, 354);
            this.gpGanhadores.TabIndex = 0;
            this.gpGanhadores.TabStop = false;
            this.gpGanhadores.Text = "Final da Votação";
            // 
            // lblPartido2
            // 
            this.lblPartido2.AutoSize = true;
            this.lblPartido2.Location = new System.Drawing.Point(203, 294);
            this.lblPartido2.Name = "lblPartido2";
            this.lblPartido2.Size = new System.Drawing.Size(93, 13);
            this.lblPartido2.TabIndex = 10;
            this.lblPartido2.Text = "Prefeito Ganhador";
            this.lblPartido2.Visible = false;
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(203, 264);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(93, 13);
            this.lblNome2.TabIndex = 9;
            this.lblNome2.Text = "Prefeito Ganhador";
            this.lblNome2.Visible = false;
            // 
            // lblCod2
            // 
            this.lblCod2.AutoSize = true;
            this.lblCod2.Location = new System.Drawing.Point(203, 234);
            this.lblCod2.Name = "lblCod2";
            this.lblCod2.Size = new System.Drawing.Size(93, 13);
            this.lblCod2.TabIndex = 8;
            this.lblCod2.Text = "Prefeito Ganhador";
            this.lblCod2.Visible = false;
            // 
            // lblPartido1
            // 
            this.lblPartido1.AutoSize = true;
            this.lblPartido1.Location = new System.Drawing.Point(6, 294);
            this.lblPartido1.Name = "lblPartido1";
            this.lblPartido1.Size = new System.Drawing.Size(93, 13);
            this.lblPartido1.TabIndex = 7;
            this.lblPartido1.Text = "Prefeito Ganhador";
            this.lblPartido1.Visible = false;
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Location = new System.Drawing.Point(6, 264);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(93, 13);
            this.lblNome1.TabIndex = 6;
            this.lblNome1.Text = "Prefeito Ganhador";
            this.lblNome1.Visible = false;
            // 
            // lblCod1
            // 
            this.lblCod1.AutoSize = true;
            this.lblCod1.Location = new System.Drawing.Point(6, 234);
            this.lblCod1.Name = "lblCod1";
            this.lblCod1.Size = new System.Drawing.Size(93, 13);
            this.lblCod1.TabIndex = 5;
            this.lblCod1.Text = "Prefeito Ganhador";
            this.lblCod1.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(144, 264);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X";
            this.lblX.Visible = false;
            // 
            // lblPrefeito
            // 
            this.lblPrefeito.AutoSize = true;
            this.lblPrefeito.Location = new System.Drawing.Point(6, 194);
            this.lblPrefeito.Name = "lblPrefeito";
            this.lblPrefeito.Size = new System.Drawing.Size(93, 13);
            this.lblPrefeito.TabIndex = 1;
            this.lblPrefeito.Text = "Prefeito Ganhador";
            // 
            // lstVereadores
            // 
            this.lstVereadores.FormattingEnabled = true;
            this.lstVereadores.Location = new System.Drawing.Point(6, 19);
            this.lstVereadores.Name = "lstVereadores";
            this.lstVereadores.Size = new System.Drawing.Size(636, 160);
            this.lstVereadores.TabIndex = 0;
            // 
            // btnFim
            // 
            this.btnFim.Location = new System.Drawing.Point(534, 372);
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(120, 44);
            this.btnFim.TabIndex = 1;
            this.btnFim.Text = "Finalizar Votação";
            this.btnFim.UseVisualStyleBackColor = true;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // FormFinalizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 437);
            this.Controls.Add(this.btnFim);
            this.Controls.Add(this.gpGanhadores);
            this.Name = "FormFinalizador";
            this.Text = "FomFinalizador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFinalizador_FormClosing);
            this.gpGanhadores.ResumeLayout(false);
            this.gpGanhadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpGanhadores;
        private System.Windows.Forms.ListBox lstVereadores;
        private System.Windows.Forms.Button btnFim;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblPrefeito;
        private System.Windows.Forms.Label lblPartido2;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblCod2;
        private System.Windows.Forms.Label lblPartido1;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblCod1;
    }
}