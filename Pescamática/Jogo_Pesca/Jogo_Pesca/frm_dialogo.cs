using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jogo_Pesca
{
    public partial class frm_dialogo : Form
    {
        int tempo = 3;
        int resultado = 0;
        SoundPlayer S ;
        public frm_dialogo(int R)
        {
            InitializeComponent();
            resultado = R;
        }

        private void frm_dialogo_Load(object sender, EventArgs e)
        {
            if (resultado == 1)
            {
                S = new SoundPlayer(@"Audios\Acerto.wav");
                S.Play();
                llb_Informa.Text = "Parabéns, você acertou!!!!";
            }
            else
            {
                S = new SoundPlayer(@"Audios\Erro.wav");
                S.Play();
                llb_Informa.Text = ("Você errou, o resultado era " + resultado.ToString());
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo--;
            if (tempo == 0)
            {
                S.Stop();
                timer1.Stop();
                Close();
            }
        }
    }
}
