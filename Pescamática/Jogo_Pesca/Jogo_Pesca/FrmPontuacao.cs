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
    public partial class FrmPontuacao : Form
    {
        public FrmPontuacao()
        {
            InitializeComponent();
        }

        private void cmd_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPontuacao_Load(object sender, EventArgs e)
        {
            string[] Line = System.IO.File.ReadAllLines(@"Dados\Pontuacao.txt");
            List<Jogador> J = new List<Jogador>();
            List<int> Auxiliar = new List<int>();
            Jogador J1;
            int k = 0;
            if (Line.Length > 1)
            {
                while (k < Line.Length)
                {
                    J1 = new Jogador();
                    J1.Nome = Line[k];
                    k++;
                    J1.Score = Convert.ToInt32(Line[k]);
                    Auxiliar.Add(int.Parse(Line[k]));
                    k++;
                    J.Add(J1);
                }
                Auxiliar.Sort();
                List<Jogador> Jog = new List<Jogador>();
                for (int i = J.Count - 1; i >= 0; i--)
                {
                    for (int j = 0; j < J.Count; j++)
                    {
                        if (J[j].Score == Auxiliar[i])
                        {
                            Jog.Add(J[j]);
                            J.RemoveAt(j);
                        }
                    }
                }
                int p = 0;
                Lt_1.View = View.Details;
                Lt_1.Columns.Add("Nome", 100);
                Lt_1.Columns.Add("Pontos", 100);
                while (p < Jog.Count)
                {
                    PopulaListView(Lt_1, Jog[p].Nome, Jog[p].Score.ToString());
                    p++;
                }
            }
        }
        private void PopulaListView(ListView listView , string Nome, string Pontos)
        {
            ListViewItem item = new ListViewItem(new[] { Nome, Pontos});
            listView.Items.Add(item);
        }
    }
}
 
