using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleicoes
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void btnVotacao_Click(object sender, EventArgs e)
        {
            if (Urna.aPrefeitos.Count > 0 && Urna.aPartidos.Count > 0 && Urna.aUrnas.Count > 0 && Urna.aVereador.Count > 0)
            {
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Para votar é necessário ter no mínimo 1 cadidato de cada, além de 1 urna e 1 eleitor !" +
                    "\nPor favor, cadastre-os !", "Abrir Urna", MessageBoxButtons.OK , MessageBoxIcon.Asterisk);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
