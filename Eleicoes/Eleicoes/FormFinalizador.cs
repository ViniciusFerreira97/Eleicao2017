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
            FinalizadorVotacao fim = new FinalizadorVotacao(Urna.aUrnas);
            for(int i = 0; i < fim.vVereadores.GetLength(1); i++)
            {
                lstVereadores.Items.Add(fim.vVereadores[i,0] + " - " + fim.vVereadores[i,1]);
            }
        }
    }
}
