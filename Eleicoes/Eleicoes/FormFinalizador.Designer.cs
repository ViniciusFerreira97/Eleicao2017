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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstVereadores = new System.Windows.Forms.ListBox();
            this.btnFim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstVereadores);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lstVereadores
            // 
            this.lstVereadores.FormattingEnabled = true;
            this.lstVereadores.Location = new System.Drawing.Point(6, 19);
            this.lstVereadores.Name = "lstVereadores";
            this.lstVereadores.Size = new System.Drawing.Size(636, 264);
            this.lstVereadores.TabIndex = 0;
            // 
            // btnFim
            // 
            this.btnFim.Location = new System.Drawing.Point(534, 343);
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(120, 44);
            this.btnFim.TabIndex = 1;
            this.btnFim.Text = "Finalizar Votação";
            this.btnFim.UseVisualStyleBackColor = true;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // FomFinalizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 399);
            this.Controls.Add(this.btnFim);
            this.Controls.Add(this.groupBox1);
            this.Name = "FomFinalizador";
            this.Text = "FomFinalizador";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstVereadores;
        private System.Windows.Forms.Button btnFim;
    }
}