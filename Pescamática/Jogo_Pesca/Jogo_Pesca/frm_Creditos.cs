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
    public partial class frm_Creditos : Form
    {
        public frm_Creditos()
        {
            InitializeComponent();
        }

        private void cmd_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
