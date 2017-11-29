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
    public partial class FrmExcluir : Form
    {
        public FrmExcluir()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (rbnPartido.Checked == true)
            {
                Partido.ExcluirPartido(int.Parse(txtExcluir.Text));
            }
            if (rbnCandidato.Checked == true)
            {
                if (rbnPrefeito.Checked == true)
                {
                    int aux = Prefeito.VerificaPosicao(int.Parse(txtExcluir.Text));
                    Prefeito x = (Prefeito)Urna.aPrefeitos[aux];
                    int aux2 = VicePrefeito.VerificaPosicao(x.GetCodVice());
                    int aux3 = Partido.verificaPosicao(x.GetPartido());
                    Prefeito.ExcluirCandidato(aux, aux2, aux3);
                    MessageBox.Show("Prefeito e Vice Prefeito excluidos com sucesso");
                }
                else if (rbnVereador.Checked == true)
                {
                    int aux = Vereador.VerificaPosicao(int.Parse(txtExcluir.Text));
                    Vereador.ExcluirCandidato(aux);
                    MessageBox.Show("Vereador excluido com sucesso");
                }
            }
            else if (rbnEleitores.Checked == true)
            {
                bool ok = Eleitor.ExcluirEleitor(txtExcluir.Text);
                if (ok)
                {
                    MessageBox.Show("Eleitor excluido com sucesso");
                }
            }
            else if (rbnUrna.Checked == true)
            {
                bool ok = Urna.ExcluirUrna(int.Parse(txtExcluir.Text));
                if (ok)
                {
                    MessageBox.Show("Urna excluida com sucesso");
                }
            }
            txtExcluir.Text = "";
        }

        private void FrmExcluir_FormClosing(object sender, FormClosingEventArgs e)
        {
            Partido.SalvarPartidos();
            VicePrefeito.SalvarVice();
            Prefeito.SalvarPrefeitos();
            Vereador.SalvarVereador();
            Urna.SalvarUrnas();
            Eleitor.SalvarEleitores();
        }

        private void rbnPartido_CheckedChanged(object sender, EventArgs e)
        {
            lblExcluir.Text = "Número";
            grpTipo.Visible = false;
        }

        private void rbnCandidato_CheckedChanged(object sender, EventArgs e)
        {
            lblExcluir.Text = "Número";
            grpTipo.Visible = true;
        }

        private void rbnEleitores_CheckedChanged(object sender, EventArgs e)
        {
            lblExcluir.Text = "N° Titulo";
            grpTipo.Visible = false;
        }

        private void rbnUrna_CheckedChanged(object sender, EventArgs e)
        {
            lblExcluir.Text = "N° Seção";
            grpTipo.Visible = false;
        }
    }
}
