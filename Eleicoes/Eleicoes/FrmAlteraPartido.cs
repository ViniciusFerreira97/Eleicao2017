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
    public partial class FrmAlteraPartido : Form
    {
        public FrmAlteraPartido()
        {
            InitializeComponent();
            txtNome.Visible = false;
            txtSigla.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            bool ok= false;
            foreach(Partido x in Urna.aPartidos)
            {
                if (x.numero == int.Parse(txtNumero.Text))
                {
                    txtNumero.Enabled = false;
                    txtNome.Visible = true;
                    txtSigla.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    txtNome.Text = x.nome;
                    txtSigla.Text = x.sigla;
                    ok = true;
                    break;
                }
            }
            if (!ok)
                MessageBox.Show("O Partido não existe");
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            foreach(Partido x in Urna.aPartidos)
            {
                if(x.numero == int.Parse(txtNumero.Text))
                {
                    x.nome = txtNome.Text;
                    x.sigla = txtSigla.Text;
                    txtNome.Text = "";
                    txtNumero.Text = "";
                    txtSigla.Text = "";
                    txtNumero.Enabled = true;
                    label2.Visible = false;
                    label3.Visible = false;
                    txtNome.Visible = false;
                    txtSigla.Visible = false;
                }
            }
        }
    }
}
