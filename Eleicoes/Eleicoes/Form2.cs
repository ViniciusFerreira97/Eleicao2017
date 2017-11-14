using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        public static ArrayList aPartidos = new ArrayList();
        public Form2()
        {
            InitializeComponent();
            rbnPartido.Checked = true;
            lblNome.Visible = true;
            lblDat.Visible = false;
            lblCodgo.Visible = false;
            lblEmail.Visible = false;
            lblPartido.Visible = false;
            txtDataNascimento.Visible = false;
            txtNome.Visible = true;
            txtVariavel1.Visible = false;
            txtVariavel3.Visible = false;
        }

        
        private void rbnPartido_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Visible = true;
            lblDat.Visible = false;
            lblCodgo.Visible = false;
            lblEmail.Visible = false;
            lblPartido.Visible = false;
            txtDataNascimento.Visible = false;
            txtNome.Visible = true;
            txtVariavel1.Visible = false;
            txtVariavel3.Visible = false;
            txtVariavel2.Visible = false;
        }

        private void rbnCandidato_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Visible = true;
            lblDat.Visible = true;
            lblCodgo.Visible = true;
            lblEmail.Visible = true;
            lblPartido.Visible = true;
            txtDataNascimento.Visible = true;
            txtVariavel1.Visible = true;
            txtVariavel3.Visible = true;
            txtVariavel2.Visible = true;
            txtNome.Visible = true;
            lblCodgo.Text = "Código";
            lblPartido.Text = "Partido";
            lblEmail.Text = "E-mail";
        }

        private void rbnEleitores_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Visible = true;
            lblDat.Visible = true;
            lblCodgo.Visible = true;
            lblEmail.Visible = true;
            lblPartido.Visible = true;
            txtDataNascimento.Visible = true;
            txtVariavel1.Visible = true;
            txtVariavel3.Visible = true;
            txtVariavel2.Visible = true;
            txtNome.Visible = true;
            lblCodgo.Text = "Zona";
            lblPartido.Text = "Seção";
            lblEmail.Text = "N° Titulo";
        }

        private void rbnUrna_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Visible = false;
            lblDat.Visible = false;
            lblCodgo.Visible = true;
            lblEmail.Visible = false;
            lblPartido.Visible = true;
            txtDataNascimento.Visible = false;
            txtVariavel1.Visible = true;
            txtVariavel3.Visible = false;
            txtVariavel2.Visible = true;
            txtNome.Visible = false;
            lblCodgo.Text = "Zona";
            lblPartido.Text = "Seção";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(rbnPartido.Checked==true)
            {
                aPartidos.Add(new Partido(txtNome.Text));
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
