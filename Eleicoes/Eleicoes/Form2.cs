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
            grpTipo.Visible = false;
            cbxPartido.Visible = false;
            grpVice.Visible = false;
            label1.Visible = false;
            txtVariavel2.Visible = false;
            rbnVereador.Checked = true;
        }
        private void zerarTudo()
        {
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            txtVariavel1.Text = "";
            txtVariavel2.Text = "";
            txtVariavel3.Text = "";
            txtNomeVice.Text = "";
            txtPartidoVice.Text = "";
            txtCodVice.Text = "";
            txtDatVice.Text = "";
            txtEmailVice.Text = "";
        }
        private void rbnPartido_CheckedChanged(object sender, EventArgs e)
        {
            txtVariavel1.Location = new Point(251, 103);
            txtVariavel2.Location = new Point(375, 103);
            rbnPrefeito.Checked = false;
            rbnVereador.Checked = false;
            lblNome.Visible = true;
            lblDat.Visible = false;
            lblCodgo.Visible = false;
            lblEmail.Visible = false;
            lblPartido.Visible = false;
            txtDataNascimento.Visible = false;
            txtNome.Visible = true;
            txtVariavel1.Visible = false;
            txtVariavel2.Visible = false;
            txtVariavel3.Visible = false;
            grpTipo.Visible = false;
            cbxPartido.Visible = false;
            grpVice.Visible = false;
            label1.Visible = false;
            lblNome.Text = "Nome";
            zerarTudo();
        }
        private void rbnCandidato_CheckedChanged(object sender, EventArgs e)
        {
            txtVariavel1.Location = new Point(251, 103);
            txtVariavel2.Location = new Point(375, 103);
            lblNome.Visible = true;
            lblDat.Visible = true;
            lblCodgo.Visible = true;
            lblEmail.Visible = true;
            lblPartido.Visible = true;
            txtDataNascimento.Visible = true;
            txtVariavel1.Visible = true;
            txtVariavel3.Visible = true;
            txtNome.Visible = true;
            txtVariavel2.Visible = false;
            cbxPartido.Visible = true;
            grpTipo.Visible = true;
            grpVice.Visible = false;
            lblCodgo.Text = "Código";
            lblPartido.Text = "Partido";
            lblEmail.Text = "E-mail";
            lblNome.Text = "Nome";
            lblDat.Text = "Data de Nascimento";
            zerarTudo();
            if (Partido.aPartidos != null) //Inicializando Itens cadastrados no arrayList no ComboBox
            {
                foreach (Partido a in Partido.aPartidos)
                {
                    cbxPartido.Items.Add(a.nome);
                }
            }
        }
        private void rbnEleitores_CheckedChanged(object sender, EventArgs e)
        {
            txtVariavel1.Location = new Point(251, 103);
            txtVariavel2.Location = new Point(375, 103);
            rbnPrefeito.Checked = false;
            rbnVereador.Checked = false;
            lblNome.Visible = true;
            lblDat.Visible = true;
            lblCodgo.Visible = true;
            lblEmail.Visible = true;
            lblPartido.Visible = true;
            txtDataNascimento.Visible = true;
            txtVariavel1.Visible = true;
            txtVariavel3.Visible = true;
            txtNome.Visible = true;
            grpTipo.Visible = false;
            cbxPartido.Visible = false;
            grpVice.Visible = false;
            label1.Visible = false;
            txtVariavel2.Visible = true;
            lblCodgo.Text = "Zona";
            lblPartido.Text = "Seção";
            lblEmail.Text = "N° Titulo";
            lblNome.Text = "Nome";
            lblDat.Text = "Data de Nascimento";
            zerarTudo();
        }
        private void rbnPrefeito_CheckedChanged(object sender, EventArgs e)
        {
            txtCodVice.Text = txtVariavel1.Text;
            txtPartidoVice.Text = cbxPartido.Text;
            txtCodVice.Enabled = false;
            txtPartidoVice.Enabled = false;
            grpTipo.Visible = true;
            grpVice.Visible = true;
            label1.Visible = true;
        }
        private void rbnVereador_CheckedChanged(object sender, EventArgs e)
        {
            grpTipo.Visible = true;
            grpVice.Visible = false;
            label1.Visible = false;
        }
        private void rbnUrna_CheckedChanged(object sender, EventArgs e)
        {
            txtVariavel1.Location = new Point(12, 103);
            txtVariavel2.Location = new Point(134, 103);
            txtVariavel2.Visible = true;
            rbnPrefeito.Checked = false;
            rbnVereador.Checked = false;
            lblNome.Visible = true;
            lblDat.Visible = true;
            lblCodgo.Visible = false;
            lblEmail.Visible = false;
            lblPartido.Visible = false;
            txtDataNascimento.Visible = false;
            txtVariavel1.Visible = true;
            txtVariavel3.Visible = false;
            txtNome.Visible = false;
            grpTipo.Visible = false;
            cbxPartido.Visible = false;
            grpVice.Visible = false;
            label1.Visible = false;
            lblNome.Text = "Zona";
            lblDat.Text = "Seção";
            zerarTudo();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(rbnPartido.Checked==true)
            {
                try
                {
                    Partido.aPartidos.Add(new Partido(txtNome.Text));
                    txtNome.Text = "";
                    MessageBox.Show("Partido cadastrado com sucesso!", "Cadastramento - Partido ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (InvalidDataException a)
                {

                    MessageBox.Show(a.Message, "Cadastramento - Partido ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rbnCandidato.Checked == true)
            {
                if(rbnPrefeito.Checked == true)
                {
                    try
                    {
                        int aux = Partido.verificaPosicao(cbxPartido.Text);
                        VicePrefeito.aVicePrefeito.Add(new VicePrefeito(txtCodVice.Text, txtNomeVice.Text, txtEmailVice.Text, txtDatVice.Text, (Partido)Partido.aPartidos[aux]));
                        int auxCod = VicePrefeito.VerificaPosicao(int.Parse(txtCodVice.Text));
                        Prefeito.aPrefeitos.Add(new Prefeito(txtVariavel1.Text, txtNome.Text, txtVariavel3.Text, txtDataNascimento.Text, (Partido)Partido.aPartidos[aux], (VicePrefeito)VicePrefeito.aVicePrefeito[auxCod]));
                    }
                    catch(InvalidDataException a)
                    {
                        MessageBox.Show(a.Message, "Cadastramento - Prefeito ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (rbnVereador.Checked == true)
                {
                    try
                    {
                        int aux = Partido.verificaPosicao(cbxPartido.Text);
                        Vereador.aVereador.Add(new Vereador(txtVariavel1.Text, txtNome.Text, txtVariavel3.Text, txtDataNascimento.Text, (Partido)Partido.aPartidos[aux]));
                    }
                    catch(InvalidDataException a)
                    {
                        MessageBox.Show(a.Message, "Cadastramento - Vereador ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (rbnEleitores.Checked == true)
            {
                Eleitor.aEleitores.Add(new Eleitor(txtNome.Text, txtDataNascimento.Text, txtVariavel3.Text, txtVariavel1.Text, txtVariavel2.Text));
            }
            else if (rbnUrna.Checked == true)
            {
                Urna.aUrnas.Add(new Urna(txtVariavel1.Text, txtVariavel2.Text));
            }
            zerarTudo();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
