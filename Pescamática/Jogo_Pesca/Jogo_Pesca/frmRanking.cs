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
    public partial class frmRanking : Form
    {
        int tempo = 5;
        public frmRanking()
        {
            InitializeComponent();
        }

        string nomeCampeao;

        public string NomeCampeao { get => nomeCampeao; set => nomeCampeao = value; }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            label1.Text = NomeCampeao;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo--;
            if (tempo == 0)
            {
                Close();
            }
        }
    }
}
