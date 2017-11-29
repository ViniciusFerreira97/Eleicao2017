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

        FormFinalizador fim = new FormFinalizador();
        public Form2()
        {
            InitializeComponent();
            //Inicializando documentos TXT.
            Partido.InicializarPartidos("Partido.txt");
            VicePrefeito.InicializarVice("VicePrefeito.txt");
            Prefeito.InicializarPrefeitos("Prefeito.txt");
            Vereador.InicializarVereador("Vereador.txt");
            Eleitor.InicializarEleitores("Eleitor.txt");
            Urna.InicializarUrnas("Urna.txt");
            //Salvando o total de votos
            foreach(Vereador v in Urna.aVereador)
            {
                Urna.totalVotos += v.votos;
            }
            foreach (Prefeito v in Urna.aPrefeitos)
            {
                Urna.totalVotos += v.votos;
            }
            //Tratando visibilidade dos objetos.
            rbnPrefeito.Checked = false;
            rbnVereador.Checked = false;
            lblNome.Visible = true;
            lblDat.Visible = true;
            lblCodgo.Visible = true;
            lblEmail.Visible = false;
            lblPartido.Visible = false;
            txtDataNascimento.Visible = false;
            txtNome.Visible = true;
            txtVariavel1.Visible = true;
            txtVariavel2.Visible = false;
            txtVariavel3.Visible = false;
            grpTipo.Visible = false;
            cbxPartido.Visible = false;
            grpVice.Visible = false;
            label1.Visible = false;
            txtSigla.Visible = true;
            lblCod2.Visible = false;
            txtCod2.Visible = false;
            cbxZonaEleitor.Visible = false;
            cbxSecaoEleitor.Visible = false;
            txtSigla.Visible = true;
            lblDat.Text = "Sigla";
            lblCodgo.Text = "Número";
            lblNome.Text = "Nome";
        }
        private void zerarTudo()
        {
            //Função para zerar todos os campos.
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
            txtSigla.Text = "";
            txtCod2.Text = "";
            cbxPartido.Text = "";
            cbxSecaoEleitor.Text = "";
            cbxZonaEleitor.Text = "";
            cbxPartido.Text = "";
        }
        private void rbnPartido_CheckedChanged(object sender, EventArgs e)
        {
            //Alterando localização do objeto
            txtVariavel1.Location = new Point(244, 99);
            txtVariavel2.Location = new Point(370, 97);
            //Tratando visibilidade dos objetos.
            rbnPrefeito.Checked = false;
            rbnVereador.Checked = false;
            lblNome.Visible = true;
            lblDat.Visible = true;
            lblCodgo.Visible = true;
            lblEmail.Visible = false;
            lblEmail.Visible = false;
            lblEmail.Visible = false;
            lblPartido.Visible = false;
            txtDataNascimento.Visible = false;
            txtNome.Visible = true;
            txtVariavel1.Visible = true;
            txtVariavel2.Visible = false;
            txtVariavel3.Visible = false;
            grpTipo.Visible = false;
            cbxPartido.Visible = false;
            grpVice.Visible = false;
            label1.Visible = false;
            txtSigla.Visible = true;
            txtVariavel1.Enabled = true;
            lblCod2.Visible = false;
            txtCod2.Visible = false;
            cbxZonaEleitor.Visible = false;
            cbxSecaoEleitor.Visible = false;
            txtCod2.Visible = false;
            lblCod2.Visible = false;
            txtSigla.Visible = true;
            lblDat.Text = "Sigla";
            lblCodgo.Text = "Número";
            lblNome.Text = "Nome";
            zerarTudo();
        }
        private void rbnCandidato_CheckedChanged(object sender, EventArgs e)
        {
            //Alterando localização do objeto
            txtVariavel1.Location = new Point(244, 99);
            txtVariavel2.Location = new Point(370, 97);
            //Tratando visibilidade e texto dos objetos.
            lblNome.Visible = true;
            lblDat.Visible = true;
            lblCodgo.Visible = true;
            lblEmail.Visible = true;
            lblPartido.Visible = true;
            txtDataNascimento.Visible = true;
            txtVariavel1.Visible = true;
            txtVariavel1.Enabled = false;
            txtVariavel3.Visible = true;
            txtNome.Visible = true;
            txtVariavel2.Visible = false;
            cbxPartido.Visible = true;
            grpTipo.Visible = true;
            grpVice.Visible = false;
            lblCod2.Visible = true;
            txtCod2.Visible = true;
            rbnVereador.Checked = true;
            cbxZonaEleitor.Visible = false;
            cbxSecaoEleitor.Visible = false;
            txtCod2.Visible = true;
            lblCod2.Visible = true;
            txtSigla.Visible = false;
            lblCodgo.Text = "Código";
            lblPartido.Text = "Partido";
            lblEmail.Text = "E-mail";
            lblNome.Text = "Nome";
            lblDat.Text = "Data de Nascimento";
            zerarTudo();
            if (Urna.aPartidos != null) //Inicializando Itens cadastrados no arrayList no ComboBox
            {
                cbxPartido.Items.Clear();
                foreach (Partido a in Urna.aPartidos)
                {
                    cbxPartido.Items.Add(a.nome);
                }
            }
        }
        private void rbnEleitores_CheckedChanged(object sender, EventArgs e)
        {
            //Alterando localização do objeto
            txtVariavel1.Location = new Point(244, 99);
            txtVariavel2.Location = new Point(370, 97);
            //Tratando visibilidade e texto dos objetos.
            rbnPrefeito.Checked = false;
            rbnVereador.Checked = false;
            lblNome.Visible = true;
            lblDat.Visible = true;
            lblCodgo.Visible = true;
            lblEmail.Visible = true;
            lblPartido.Visible = true;
            txtDataNascimento.Visible = true;
            txtVariavel1.Visible = false;
            txtVariavel3.Visible = true;
            txtNome.Visible = true;
            grpTipo.Visible = false;
            cbxPartido.Visible = false;
            grpVice.Visible = false;
            label1.Visible = false;
            txtVariavel2.Visible = false;
            txtVariavel1.Enabled = true;
            cbxZonaEleitor.Visible = true;
            cbxSecaoEleitor.Visible = true;
            txtCod2.Visible = false;
            lblCod2.Visible = false;
            txtSigla.Visible = false;
            lblCodgo.Text = "Zona";
            lblPartido.Text = "Seção";
            lblEmail.Text = "N° Titulo";
            lblNome.Text = "Nome";
            lblDat.Text = "Data de Nascimento";
            if (Urna.aUrnas != null) //Inicializando Itens cadastrados no arrayList no ComboBox
            {
                cbxZonaEleitor.Items.Clear();
                cbxSecaoEleitor.Items.Clear();
                foreach (Urna a in Urna.aUrnas)
                {
                    cbxZonaEleitor.Items.Add(a.getZona());
                    cbxSecaoEleitor.Items.Add(a.getSecao());
                }
            }
            zerarTudo();
        }
        private void rbnPrefeito_CheckedChanged(object sender, EventArgs e)
        {
            //Tratando visibilidade dos objetos.
            txtCodVice.Text = txtVariavel1.Text;
            txtCodVice.Enabled = false;
            txtPartidoVice.Enabled = false;
            grpTipo.Visible = true;
            grpVice.Visible = true;
            label1.Visible = true;
            lblCod2.Visible = false;
            txtCod2.Visible = false;
            txtCod2.Visible = false;
            lblCod2.Visible = false;
        }
        private void rbnVereador_CheckedChanged(object sender, EventArgs e)
        {
            //Tratando visibilidade dos objetos.
            grpTipo.Visible = true;
            grpVice.Visible = false;
            label1.Visible = false;
            lblCod2.Visible = true;
            txtCod2.Visible = true;
            txtCod2.Visible = true;
            lblCod2.Visible = true;
        }
        private void rbnUrna_CheckedChanged(object sender, EventArgs e)
        {
            //Alterando localização do objeto
            txtVariavel1.Location = new Point(5, 99);
            txtVariavel2.Location = new Point(127, 99);
            //Tratando visibilidade e texto dos objetos.
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
            txtVariavel1.Enabled = true;
            cbxZonaEleitor.Visible = false;
            cbxSecaoEleitor.Visible = false;
            txtCod2.Visible = false;
            lblCod2.Visible = false;
            txtSigla.Visible = false;
            lblNome.Text = "Zona";
            lblDat.Text = "Seção";
            zerarTudo();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (rbnPartido.Checked == true)
            {
                try
                {
                    Urna.aPartidos.Add(new Partido(txtNome.Text, txtSigla.Text, txtVariavel1.Text));
                    txtNome.Text = "";
                    MessageBox.Show("Partido cadastrado com sucesso!", "Cadastramento - Partido ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (InvalidDataException a)
                {

                    MessageBox.Show(a.Message, "Cadastramento - Partido ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbnCandidato.Checked == true)
            {
                if (rbnPrefeito.Checked == true)
                {
                    try
                    {
                        int aux = Partido.verificaPosicao(cbxPartido.Text); //Chamando função para verificar em qual posição di array se encontra o partido.
                        Urna.aVicePrefeito.Add(new VicePrefeito(txtCodVice.Text, txtNomeVice.Text, txtEmailVice.Text, txtDatVice.Text, (Partido)Urna.aPartidos[aux]));
                        int auxCod = VicePrefeito.VerificaPosicao(int.Parse(txtCodVice.Text)); //Chamando função para verificar em qual posição do array se encontra o vereador.
                        Urna.aPrefeitos.Add(new Prefeito(txtVariavel1.Text, txtNome.Text, txtVariavel3.Text, txtDataNascimento.Text, (Partido)Urna.aPartidos[aux], (VicePrefeito)Urna.aVicePrefeito[auxCod]));
                    }
                    catch (InvalidDataException a)
                    {
                        MessageBox.Show(a.Message, "Cadastramento - Prefeito ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (rbnVereador.Checked == true)
                {
                    try
                    {
                        int aux = Partido.verificaPosicao(cbxPartido.Text); //Chamando função para verificar em qual posição di array se encontra o partido.
                        Urna.aVereador.Add(new Vereador((txtVariavel1.Text + txtCod2.Text), txtNome.Text, txtVariavel3.Text, txtDataNascimento.Text, (Partido)Urna.aPartidos[aux]));
                    }
                    catch (InvalidDataException a)
                    {
                        MessageBox.Show(a.Message, "Cadastramento - Vereador ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                rbnPrefeito.Checked = false;
                rbnVereador.Checked = false;
                grpTipo.Visible = true;
                grpVice.Visible = false;
                label1.Visible = false;
            }
            else if (rbnEleitores.Checked == true)
            {
                Eleitor.aEleitores.Add(new Eleitor(txtNome.Text, txtDataNascimento.Text, txtVariavel3.Text, cbxZonaEleitor.Text, cbxSecaoEleitor.Text));
            }
            else if (rbnUrna.Checked == true)
            {
                Urna.aUrnas.Add(new Urna(txtVariavel1.Text, txtVariavel2.Text));
            }
            zerarTudo();
            rbnVereador.Checked = true;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Salvando os dados em um documento txt.
            Partido.SalvarPartidos();
            VicePrefeito.SalvarVice();
            Prefeito.SalvarPrefeitos();
            Vereador.SalvarVereador();
            Urna.SalvarUrnas();
            Eleitor.SalvarEleitores();
            //Abrindo novamente o Form1.
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FrmExcluir excluir = new FrmExcluir();
            excluir.Show();
        }

        private void ckbExcluir_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Excluir";
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            if (Urna.totalVotos > 3)
            {
                fim.Show();
                this.Hide();
            }
            else
                MessageBox.Show("É necessário ao minimo 3 votos para encerrar a votação",
                    "Finalizar - Votação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void cbxPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux = Partido.verificaPosicao(cbxPartido.Text);
            Partido x = Urna.aPartidos[aux];
            txtVariavel1.Text = Convert.ToString(x.numero);
            txtPartidoVice.Text = cbxPartido.Text;
            txtCodVice.Text = Convert.ToString(x.numero);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmAlteraPartido frmAltera = new FrmAlteraPartido();
            frmAltera.Show();
        }
    }
}
