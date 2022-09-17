using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Pesca
{
    public partial class frm_Inicio : Form
    {
        public frm_Inicio()
        {
            InitializeComponent();
        }

        private void cmd_inicio_Click(object sender, EventArgs e)
        {
            frm_Nome FN = new frm_Nome();
            FN.ShowDialog();
        }

        private void cmd_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_Ranking_Click(object sender, EventArgs e)
        {
            FrmPontuacao p = new FrmPontuacao();
            p.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Creditos c = new frm_Creditos();
            c.ShowDialog();
        }
    }
}
