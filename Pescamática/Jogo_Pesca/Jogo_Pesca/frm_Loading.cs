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
    public partial class frm_Loading : Form
    {
        int tempo;
        public frm_Loading()
        {
            InitializeComponent();
        }

        private void frm_Loading_Load(object sender, EventArgs e)
        {
            tempo = 3;
            timer1.Start();
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo--;
            progressBar1.Value += 33;
            if (tempo == 0)
            {
                progressBar1.Value = 100;
                timer1.Stop();
                Close();
            }
        }
    }
}
