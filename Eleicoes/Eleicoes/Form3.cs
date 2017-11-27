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

        int[,] votosPrefeitos = new int[Urna.aPrefeitos.Count, 2];
        bool prefeito = true;


        private int votosNulosPref;
        private int votosBrancosPref;
        private int votosNulosVer;
        private int votosBrancosVer;

        int[,] votosVereador = new int[Urna.aVereador.Count, 2];

        int zona, secao, urnaPos;


        public Form3()
        {
            InitializeComponent();
            for (int c = 0; c < votosPrefeitos.GetLength(0); c++)
            {
                    votosPrefeitos[c, 0] = Urna.aPrefeitos[c].GetCodigo();
                    votosPrefeitos[c, 1] = 0;
            }
            for(int c = 0; c < votosVereador.GetLength(0); c++)
            {
                votosVereador[c, 0] = Urna.aVereador[c].GetCodigo();
                votosVereador[c, 1] = 0;
            }
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Eleitor.aEleitores.Count != 0)
            {
                Eleitor.GetZonaESecao(txtBTitulo.Text, out zona, out secao);
                urnaPos = Urna.GetUrna(zona, secao);
                Urna.aUrnas[urnaPos].SetVotos(votosPrefeitos, votosVereador, votosNulosPref, votosBrancosPref, votosNulosVer, votosBrancosVer);
            }
            Partido.SalvarPartidos();
            VicePrefeito.SalvarVice();
            Prefeito.SalvarPrefeitos();
            Vereador.SalvarVereador();
            Urna.SalvarUrnas();
            Eleitor.SalvarEleitores();
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

        //Alterar o modo de votação para Vereador
        public void alterarVotacaoVereador()
        {

            lblCargo.Text = "VEREADOR";
            lblVice.Enabled = false;
            txtViceNome.Enabled = false;
            txtViceNome.Visible = false;
            lblVice.Visible = false;
            mskVotacao.Mask = "0000";
            prefeito = false;
        }

        // Apagar instruções de confirmação
        public void limparVisorDeConfirmacao()
        {
            lblAperta.Enabled = false;
            lblVerde.Enabled = false;
            lblVerme.Enabled = false;
            lblAperta.Visible = false;
            lblVerde.Visible = false;
            lblVerme.Visible = false;

        }

        // Mostrar instruções de confirmação
        public void mostrarVisorDeConfirmaca()
        {

            lblAperta.Enabled = true;
            lblVerde.Enabled = true;
            lblVerme.Enabled = true;
            lblAperta.Visible = true;
            lblVerde.Visible = true;
            lblVerme.Visible = true;

        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            //Teste inicial para verificar se foi digitado um titulo de Eleitor
            if (string.IsNullOrEmpty(txtBTitulo.Text))
            {
                MessageBox.Show("Favor digitar o Titulo de Eleitor");
            }
            else
            {
                //Teste inicial para verificar se o eleitor esta cadastrado
                if (Eleitor.VerificaExistencia(txtBTitulo.Text))
                {

                    MessageBox.Show("Favor digitar o Titulo de Eleitor já cadastrado");
                }
                else
                {
                    //Desativando a edição do titulo de eleitor
                    txtBTitulo.Enabled = false;

                    //Verificando se a votação é para prefeito ou para vereador
                    if (prefeito)
                    {
                        votosBrancosPref++;
                        alterarVotacaoVereador();
                    }
                    else
                    {
                        votosBrancosVer++;
                        this.Close();
                    }
                }
            }
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            //Limpando o textboxs
            mskVotacao.Text = "";
            txtBNome.Text = "";
            txtBPartido.Text = "";
            limparVisorDeConfirmacao();

            //Verificando se a votação é para prefeito ou para vereador
            if (prefeito)
            {
                txtViceNome.Text = "";

            }
            confirmar = false;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            //Teste inicial para verificar se foi digitado um titulo de Eleitor
            if (string.IsNullOrEmpty(txtBTitulo.Text))
            {
                MessageBox.Show("Favor digitar o Titulo de Eleitor");
            }
            else
            {
                //Teste inicial para verificar se o eleitor esta cadastrado
                if (Eleitor.VerificaExistencia(txtBTitulo.Text))
                {

                    MessageBox.Show("Favor digitar o Titulo de Eleitor já cadastrado");
                }
                else
                {
                    //Desativando a edição do titulo de eleitor
                    txtBTitulo.Enabled = false;

                    int aux = 0;
                    bool nulo = false;

                    //Verificando se a votação é para prefeito ou para vereador
                    if (prefeito)
                    {
                        //Verificando se foi digitado algo.
                        if (mskVotacao.Text != "")
                        {
                            //rodando a matriz de prefeitos verificando se o codigo digitado pertence a algum prefeito
                            for (int c = 0; c < votosPrefeitos.GetLength(0); c++)
                            {
                                if (mskVotacao.Text == votosPrefeitos[c, 0].ToString())
                                {
                                    aux = c;
                                }
                            }

                            //Verificando se o voto é nulo, se aux for igual a zero e se na posição 0 da matriz não tiver o codigo do prefeito igual ao digitado é considerado nulo.
                            if (aux == 0 && mskVotacao.Text != votosPrefeitos[0, 0].ToString())
                            {
                                nulo = true;
                            }

                            //Verificando se o botão Confirma ja foi pressionado
                            if (!confirmar)
                            {
                                //Verificando se é nulo
                                if (!nulo)
                                {
                                    txtBNome.Text = Urna.aPrefeitos[aux].GetNome();

                                    txtBPartido.Text = Urna.aPrefeitos[aux].GetNomePartido();
                                    txtViceNome.Text = Urna.aPrefeitos[aux].GetNomeVice();

                                    mostrarVisorDeConfirmaca();

                                    confirmar = true;
                                }
                                else
                                {
                                    txtBNome.Text = "Nulo";
                                    txtViceNome.Text = "Nulo";
                                    txtBPartido.Text = "Nulo";

                                    mostrarVisorDeConfirmaca();
                                    
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

                                    limparVisorDeConfirmacao();

                                    alterarVotacaoVereador();

                                    confirmar = false;
                                }
                                else
                                {
                                    votosNulosPref++;

                                    mskVotacao.Text = "";
                                    txtBNome.Text = "";
                                    txtBPartido.Text = "";
                                    txtViceNome.Text = "";

                                    limparVisorDeConfirmacao();

                                    alterarVotacaoVereador();

                                    confirmar = false;

                                }
                            }
                        }
                        else
                        {
                            //Verificando se o botão Confirma ja foi pressionado
                            if (!confirmar)
                            {

                                txtBNome.Text = "Branco";
                                txtViceNome.Text = "Branco";
                                txtBPartido.Text = "Branco";

                                mostrarVisorDeConfirmaca();


                                confirmar = true;
                            }
                            else
                            {
                                votosBrancosPref++;

                                mskVotacao.Text = "";
                                txtBNome.Text = "";
                                txtBPartido.Text = "";
                                txtViceNome.Text = "";

                                limparVisorDeConfirmacao();
                                
                                alterarVotacaoVereador();

                                confirmar = false;
                            }

                        }

                    }
                    else
                    {
                        //Verificando se foi digitado algo.
                        if (mskVotacao.Text != "")
                        {
                            //rodando a matriz de vereadores verificando se o codigo digitado pertence a algum prefeito
                            for (int c = 0; c < votosVereador.GetLength(0); c++)
                            {
                                if (mskVotacao.Text == votosVereador[c, 0].ToString())
                                {
                                    aux = c;
                                }
                            }

                            //Verificando se o voto é nulo, se aux for igual a zero e se na posição 0 da matriz não tiver o codigo do vereador igual ao digitado é considerado nulo.
                            if (aux == 0 && mskVotacao.Text != votosVereador[0, 0].ToString())
                            {
                                nulo = true;
                            }

                            //Verificando se o botão Confirma foi pressionado
                            if (!confirmar)
                            {
                                //Verificando se é nulo
                                if (!nulo)
                                {
                                    txtBNome.Text = Urna.aVereador[aux].GetNome();

                                    txtBPartido.Text = Urna.aVereador[aux].GetNomePartido();
                                    
                                    mostrarVisorDeConfirmaca();

                                    confirmar = true;
                                }
                                else
                                {
                                    txtBNome.Text = "Nulo";

                                    txtBPartido.Text = "Nulo";

                                    mostrarVisorDeConfirmaca();

                                    confirmar = true;

                                }
                            }
                            else
                            {
                                //Verificando se é nulo
                                if (!nulo)
                                {
                                    votosVereador[aux, 1]++;
                                    mskVotacao.Text = "";
                                    txtBNome.Text = "";
                                    txtBPartido.Text = "";

                                    limparVisorDeConfirmacao();


                                    this.Close();

                                    confirmar = false;
                                }
                                else
                                {
                                    votosNulosVer++;

                                    mskVotacao.Text = "";
                                    txtBNome.Text = "";
                                    txtBPartido.Text = "";

                                    limparVisorDeConfirmacao();

                                    this.Close();

                                    confirmar = false;

                                }
                            }
                        }
                        else
                        {
                            //Verificando se o botão Confirma foi pressionado
                            if (!confirmar)
                            {
                                txtBNome.Text = "Branco";

                                txtBPartido.Text = "Branco";


                                mostrarVisorDeConfirmaca();

                                confirmar = true;
                            }
                            else
                            {
                                votosBrancosVer++;

                                mskVotacao.Text = "";
                                txtBNome.Text = "";
                                txtBPartido.Text = "";

                                limparVisorDeConfirmacao();

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
