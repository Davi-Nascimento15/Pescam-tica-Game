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
    public partial class frm_Nome : Form
    {
        private Jogador Jogador = new Jogador();
        //List<Jogador> Lista = new List<Jogador>();
        public frm_Nome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Jogador.Nome = "Player1";
            }
            else
            {
                Jogador.Nome = textBox1.Text;
            }
            frm_Principal Jogo = new frm_Principal();
            Jogo.J = Jogador;
            Jogo.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
