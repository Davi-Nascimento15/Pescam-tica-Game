using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Pesca
{
    public class Jogador
    {
        private string nome;
        private int score;

        public Jogador()
        {

        }
        public string Nome { get => nome; set => nome = value; }
        public int Score { get => score; set => score = value; }
    }
}
