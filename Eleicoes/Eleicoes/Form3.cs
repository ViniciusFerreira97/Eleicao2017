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
    public partial class Form3 : Form
    {
        bool confirmar = false;

        int[,] votosPrefeitos = new int[Prefeito.aPrefeitos.Count, 2];
        int votosNulos;
        int votosBrancos;
        bool prefeito = true;

        int[,] votosVereador = new int[Vereador.aVereador.Count, 2];

        int zona, secao, urnaPos;


        public Form3()
        {
            InitializeComponent();
            
            for (int c = 0; c < votosPrefeitos.GetLength(0); c++)
            {
                    votosPrefeitos[c, 0] = Prefeito.aPrefeitos[c].GetCodigo();
                    votosPrefeitos[c, 1] = 0;
            }
            for(int c = 0; c < votosVereador.GetLength(0); c++)
            {
                votosVereador[c, 0] = Vereador.aVereador[c].GetCodigo();
                votosVereador[c, 1] = 0;
            }
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Eleitor.aEleitores.Count != 0)
            {
                Eleitor.GetZonaESecao(txtBTitulo.Text, out zona, out secao);
                urnaPos = Urna.GetUrna(zona, secao);
                Urna.aUrnas[urnaPos].SetVotos(votosPrefeitos, votosVereador, votosNulos, votosBrancos);
            }

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            mskVotacao.Text += "1";
        }

        private void btn02_Click(object sender, EventArgs e)
        {

            mskVotacao.Text += "2";
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            mskVotacao.Text += "3";

        }

        private void btn04_Click(object sender, EventArgs e)
        {
            mskVotacao.Text += "4";

        }

        private void btn05_Click(object sender, EventArgs e)
        {
            mskVotacao.Text += "5";

        }

        private void btn06_Click(object sender, EventArgs e)
        {
            mskVotacao.Text += "6";

        }

        private void btn07_Click(object sender, EventArgs e)
        {

            mskVotacao.Text += "7";
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            mskVotacao.Text += "8";

        }

        private void btn09_Click(object sender, EventArgs e)
        {
            mskVotacao.Text += "9";

        }

        private void btn00_Click(object sender, EventArgs e)
        {

            mskVotacao.Text += "0";
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBTitulo.Text))
            {
                MessageBox.Show("Favor digitar o Titulo de Eleitor");
            }
            else
            {
                if (Eleitor.VerificaExistencia(txtBTitulo.Text))
                {

                    MessageBox.Show("Favor digitar o Titulo de Eleitor já cadastrado");
                }
                else
                {
                    txtBTitulo.Enabled = false;
                    if (prefeito)
                    {
                        votosBrancos++;
                        lblVice.Visible = false;
                    }
                    else
                    {
                        votosBrancos++;
                        this.Close();
                    }
                }
            }
        }

                private void btnCorrige_Click(object sender, EventArgs e)
        {
            mskVotacao.Text = "";
            txtBNome.Text = "";
            txtBPartido.Text = "";
            lblAperta.Enabled = false;
            lblVerde.Enabled = false;
            lblVerme.Enabled = false;
            lblAperta.Visible = false;
            lblVerde.Visible = false;
            lblVerme.Visible = false;
            confirmar = false;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBTitulo.Text))
            {
                MessageBox.Show("Favor digitar o Titulo de Eleitor");
            }
            else
            {
                if (Eleitor.VerificaExistencia(txtBTitulo.Text))
                {

                    MessageBox.Show("Favor digitar o Titulo de Eleitor já cadastrado");
                }
                else
                {
                    txtBTitulo.Enabled = false;

                    int aux = 0;
                    bool nulo = false;
                    if (prefeito)
                    {
                        if (mskVotacao.Text != "")
                        {

                            for (int c = 0; c < votosPrefeitos.GetLength(0); c++)
                            {
                                if (mskVotacao.Text == votosPrefeitos[c, 0].ToString())
                                {
                                    aux = c;
                                }
                            }

                            if (aux == 0 && mskVotacao.Text != votosPrefeitos[0, 0].ToString())
                            {
                                nulo = true;
                            }

                            if (!confirmar)
                            {
                                if (!nulo)
                                {
                                    txtBNome.Text = Prefeito.aPrefeitos[aux].GetNome();

                                    txtBPartido.Text = Prefeito.aPrefeitos[aux].GetNomePartido();
                                    txtViceNome.Text = Prefeito.aPrefeitos[aux].GetNomeVice();

                                    lblAperta.Enabled = true;
                                    lblVerde.Enabled = true;
                                    lblVerme.Enabled = true;
                                    lblAperta.Visible = true;
                                    lblVerde.Visible = true;
                                    lblVerme.Visible = true;

                                    confirmar = true;
                                }
                                else
                                {
                                    txtBNome.Text = "Nulo";

                                    txtViceNome.Text = "Nulo";
                                    txtBPartido.Text = "Nulo";
                                    lblAperta.Enabled = true;
                                    lblVerde.Enabled = true;
                                    lblVerme.Enabled = true;
                                    lblAperta.Visible = true;
                                    lblVerde.Visible = true;
                                    lblVerme.Visible = true;


                                    confirmar = true;

                                }
                            }
                            else
                            {
                                if (!nulo)
                                {
                                    votosPrefeitos[aux, 1]++;
                                    mskVotacao.Text = "";
                                    txtBNome.Text = "";
                                    txtBPartido.Text = "";
                                    txtViceNome.Text = "";
                                    lblAperta.Enabled = false;
                                    lblVerde.Enabled = false;
                                    lblVerme.Enabled = false;
                                    lblAperta.Visible = false;
                                    lblVerde.Visible = false;
                                    lblVerme.Visible = false;


                                    lblCargo.Text = "VEREADOR";
                                    lblVice.Enabled = false;
                                    txtViceNome.Enabled = false;
                                    txtViceNome.Visible = false;
                                    lblVice.Visible = false;
                                    mskVotacao.Mask = "0000";

                                    confirmar = false;
                                    prefeito = false;
                                }
                                else
                                {
                                    votosNulos++;

                                    mskVotacao.Text = "";
                                    txtBNome.Text = "";
                                    txtBPartido.Text = "";
                                    txtViceNome.Text = "";
                                    lblAperta.Enabled = false;
                                    lblVerde.Enabled = false;
                                    lblVerme.Enabled = false;
                                    lblAperta.Visible = false;
                                    lblVerde.Visible = false;
                                    lblVerme.Visible = false;


                                    lblCargo.Text = "VEREADOR";
                                    lblVice.Enabled = false;
                                    txtViceNome.Enabled = false;
                                    txtViceNome.Visible = false;
                                    lblVice.Visible = false;
                                    mskVotacao.Mask = "0000";

                                    confirmar = false;
                                    prefeito = false;

                                }
                            }
                        }
                        else
                        {
                            if (!confirmar)
                            {
                                txtBNome.Text = "Branco";
                                txtViceNome.Text = "Branco";

                                txtBPartido.Text = "Branco";
                                lblAperta.Enabled = true;
                                lblVerde.Enabled = true;
                                lblVerme.Enabled = true;
                                lblAperta.Visible = true;
                                lblVerde.Visible = true;
                                lblVerme.Visible = true;

                                confirmar = true;
                            }
                            else
                            {
                                votosBrancos++;

                                mskVotacao.Text = "";
                                txtBNome.Text = "";
                                txtBPartido.Text = "";
                                txtViceNome.Text = "";
                                lblAperta.Enabled = false;
                                lblVerde.Enabled = false;
                                lblVerme.Enabled = false;
                                lblAperta.Visible = false;
                                lblVerde.Visible = false;
                                lblVerme.Visible = false;


                                lblCargo.Text = "VEREADOR";
                                lblVice.Enabled = false;
                                txtViceNome.Enabled = false;
                                txtViceNome.Visible = false;
                                lblVice.Visible = false;
                                mskVotacao.Mask = "0000";

                                confirmar = false;
                                prefeito = false;
                            }

                        }

                    }
                    else
                    {

                        if (mskVotacao.Text != "")
                        {

                            for (int c = 0; c < votosVereador.GetLength(0); c++)
                            {
                                if (mskVotacao.Text == votosVereador[c, 0].ToString())
                                {
                                    aux = c;
                                }
                            }

                            if (aux == 0 && mskVotacao.Text != votosVereador[0, 0].ToString())
                            {
                                nulo = true;
                            }

                            if (!confirmar)
                            {
                                if (!nulo)
                                {
                                    txtBNome.Text = Vereador.aVereador[aux].GetNome();

                                    txtBPartido.Text = Vereador.aVereador[aux].GetNomePartido();

                                    lblAperta.Enabled = true;
                                    lblVerde.Enabled = true;
                                    lblVerme.Enabled = true;
                                    lblAperta.Visible = true;
                                    lblVerde.Visible = true;
                                    lblVerme.Visible = true;

                                    confirmar = true;
                                }
                                else
                                {
                                    txtBNome.Text = "Nulo";

                                    txtBPartido.Text = "Nulo";
                                    lblAperta.Enabled = true;
                                    lblVerde.Enabled = true;
                                    lblVerme.Enabled = true;
                                    lblAperta.Visible = true;
                                    lblVerde.Visible = true;
                                    lblVerme.Visible = true;

                                    confirmar = true;

                                }
                            }
                            else
                            {
                                if (!nulo)
                                {
                                    votosVereador[aux, 1]++;
                                    mskVotacao.Text = "";
                                    txtBNome.Text = "";
                                    txtBPartido.Text = "";
                                    lblAperta.Enabled = false;
                                    lblVerde.Enabled = false;
                                    lblVerme.Enabled = false;
                                    lblAperta.Visible = false;
                                    lblVerde.Visible = false;
                                    lblVerme.Visible = false;


                                    this.Close();

                                    confirmar = false;
                                }
                                else
                                {
                                    votosNulos++;

                                    mskVotacao.Text = "";
                                    txtBNome.Text = "";
                                    txtBPartido.Text = "";
                                    lblAperta.Enabled = false;
                                    lblVerde.Enabled = false;
                                    lblVerme.Enabled = false;
                                    lblAperta.Visible = false;
                                    lblVerde.Visible = false;
                                    lblVerme.Visible = false;

                                    this.Close();

                                    confirmar = false;

                                }
                            }
                        }
                        else
                        {
                            if (!confirmar)
                            {
                                txtBNome.Text = "Branco";

                                txtBPartido.Text = "Branco";
                                lblAperta.Enabled = true;
                                lblVerde.Enabled = true;
                                lblVerme.Enabled = true;
                                lblAperta.Visible = true;
                                lblVerde.Visible = true;
                                lblVerme.Visible = true;

                                confirmar = true;
                            }
                            else
                            {
                                votosBrancos++;

                                mskVotacao.Text = "";
                                txtBNome.Text = "";
                                txtBPartido.Text = "";
                                lblAperta.Enabled = false;
                                lblVerde.Enabled = false;
                                lblVerme.Enabled = false;
                                lblAperta.Visible = false;
                                lblVerde.Visible = false;
                                lblVerme.Visible = false;

                                this.Close();

                                confirmar = false;
                            }

                        }

                    }
                }
            }
            
            
        }
    }
}
