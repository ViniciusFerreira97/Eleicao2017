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
    public partial class FormFinalizador : Form
    {
        public FormFinalizador()
        {
            InitializeComponent();
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            FinalizadorVotacao fim = new FinalizadorVotacao(Urna.aVereador);
            // Escrevendo os vereadores no ListBox
            foreach (Vereador ver in Urna.aVereador)
                lstVereadores.Items.Add(ver.ToString());

            if (fim.getVencedor() != null)
            {
                //Deixa os campos visíveis
                lblCod1.Visible = true;
                lblNome1.Visible = true;
                lblPartido1.Visible = true;

                // Caso getVencedor não seja null, então houve apenas um ganhador
                lblCod1.Text = Convert.ToString(fim.getVencedor().GetCodigo());
                lblNome1.Text = fim.getVencedor().GetNome();
                lblPartido1.Text = fim.getVencedor().GetNomePartido();
            }
            else
            {
                lblPrefeito.Text = "Haverá segundo turno entre";
                //Deixa os campos visíbeis
                lblCod1.Visible = true;
                lblNome1.Visible = true;
                lblPartido1.Visible = true;
                lblCod2.Visible = true;
                lblNome2.Visible = true;
                lblPartido2.Visible = true;

                // Caso getVencedor seja null, então haverá segundo turno
                lblCod1.Text = Convert.ToString(fim.getSegundoTurno()[0].GetCodigo());
                lblNome1.Text = fim.getSegundoTurno()[0].GetNome();
                lblPartido1.Text = fim.getSegundoTurno()[0].GetNomePartido();

                lblCod2.Text = Convert.ToString(fim.getSegundoTurno()[1].GetCodigo());
                lblNome2.Text = fim.getSegundoTurno()[1].GetNome();
                lblPartido2.Text = fim.getSegundoTurno()[1].GetNomePartido();
            }
        }
    }
}
