namespace Eleicoes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnVotacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdm
            // 
            this.btnAdm.Location = new System.Drawing.Point(90, 54);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(125, 68);
            this.btnAdm.TabIndex = 0;
            this.btnAdm.Text = "Administrador";
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // btnVotacao
            // 
            this.btnVotacao.Location = new System.Drawing.Point(90, 150);
            this.btnVotacao.Name = "btnVotacao";
            this.btnVotacao.Size = new System.Drawing.Size(125, 68);
            this.btnVotacao.TabIndex = 1;
            this.btnVotacao.Text = "Votação";
            this.btnVotacao.UseVisualStyleBackColor = true;
            this.btnVotacao.Click += new System.EventHandler(this.btnVotacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 290);
            this.Controls.Add(this.btnVotacao);
            this.Controls.Add(this.btnAdm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnVotacao;
    }
}

