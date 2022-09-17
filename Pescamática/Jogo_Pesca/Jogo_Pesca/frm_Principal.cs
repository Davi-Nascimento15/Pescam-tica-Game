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
    public partial class frm_Principal : Form
    {
        public Jogador J = new Jogador();
        List<Control> B = new List<Control>();
        int tempo1 = 15;
        int I = 0;
        int ind_Image = 1;
        string[] Line = System.IO.File.ReadAllLines(@"Dados\Basedados1.txt");
        int[] X = new int[8];
        int[] Y = new int[8];
        SoundPlayer S;
        public frm_Principal()
        {
            InitializeComponent();
        }
        private void frm_Principal_Load(object sender, EventArgs e)
        {
            frm_Loading Lo = new frm_Loading();
            Lo.ShowDialog();
            Update();
            S = new SoundPlayer(@"Audios\Fundo.wav");
            S.Play();
            int ind = 0;
            txt_tempoPrincipal.Text = "00:00:15";
            txt_Pergunta.Text = Line[I];
            I++;
            foreach (Control item in Controls)
            {
                foreach (Control item1 in Controls)
                {
                    if ((item1 is Button)&& (("button" + (ind + 1).ToString()) == item1.Name.ToString()))
                    {
                        B.Add(item1);
                        ind++;
                    }
                }
            }
            ind = 0;
            foreach (Control item1 in B)
            {
                foreach (Control item2 in B)
                {
                    if (item2 is Button)
                    {
                        if (("button" + (ind + 1).ToString()) == item2.Name.ToString())
                        {
                            if((ind) == 4)
                            {
                                item2.Text = "            " + Line[I].ToString();
                            }
                            else
                            {
                                item2.Text = Line[I].ToString();
                            }
                            item2.Tag = Line[I].ToString();
                            X[ind] = item2.Location.X;
                            Y[ind] = item2.Location.Y;
                            I++;
                            ind++;
                        }
                    }
                }
            }
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo1--;
            if (tempo1 <= 0)
            {
                txt_tempoPrincipal.Text = "00:00:0" + tempo1.ToString();
                timer1.Stop();
                S.Stop();
                tempo1 = 2;
                frm_dialogo D = new frm_dialogo(int.Parse(Line[I]));
                D.ShowDialog();
                I++;
                tempo1 = 0;
                if (I < Line.Length)
                {
                    if (ind_Image == 0)
                    {
                        Correcao C = new Correcao();
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = true;
                        BackgroundImage = Properties.Resources.mar_novo;
                        C.ShowDialog();
                        S.Play();
                        Update();
                        ind_Image++;

                    }
                    else if (ind_Image == 1)
                    {

                        Correcao C = new Correcao();
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        BackgroundImage = Properties.Resources._4175396;
                        C.ShowDialog();
                        S.Play();
                        Update();
                        ind_Image++;
                    }
                    else if (ind_Image == 2)
                    {
                        Correcao C = new Correcao();
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        BackgroundImage = Properties.Resources._4202419;
                        C.ShowDialog();
                        S.Play();
                        Update();
                        ind_Image++;
                    }
                    else if (ind_Image == 3)
                    {

                        Correcao C = new Correcao();
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        BackgroundImage = Properties.Resources._785;
                        C.ShowDialog();
                        S.Play();
                        Update();
                        ind_Image++;
                    }
                    else if (ind_Image == 4)
                    {

                        Correcao C = new Correcao();
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        BackgroundImage = Properties.Resources._4220362;
                        C.ShowDialog();
                        S.Play();
                        Update();
                        ind_Image++;
                    }
                    else if (ind_Image == 5)
                    {

                        Correcao C = new Correcao();
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        BackgroundImage = Properties.Resources._4209245;
                        C.ShowDialog();
                        S.Play();
                        Update();
                        ind_Image++;
                    }
                    else if (ind_Image == 6)
                    {
                        Correcao C = new Correcao();
                        BackgroundImage = Properties.Resources._4206901;
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        C.ShowDialog();
                        S.Play();
                        Update();
                        ind_Image = 0;
                    }
                }
            }
            else
            {
                if (tempo1 > 9)
                    txt_tempoPrincipal.Text = "00:00:" + tempo1.ToString();
                else
                    txt_tempoPrincipal.Text = "00:00:0" + tempo1.ToString();
            }
        }

        int status = 1;//Sobe ou desce
        
        //Atualiza o fomulário
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tempo1 == 0)
            {
                if (I < Line.Length)
                {
                    txt_Pergunta.Text = Line[I];
                    I++;
                    foreach (Control item in B)
                    {
                        if (item is Button)
                        {
                            if (item.Name=="button5")
                            {
                                item.Text = "            " + Line[I].ToString();
                            }
                            else
                            {
                                item.Text = Line[I].ToString();
                            }
                            item.Tag = Line[I].ToString();
                            I++;
                        }
                    }
                    tempo1 = 15;
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    timer2.Stop();
                    S.Stop();
                    ind_Image = 7;
                    frmRanking R = new frmRanking();
                    R.NomeCampeao = "PARABÉNS " + J.Nome + "! VOCÊ FEZ " + J.Score.ToString() + " PONTOS!";
                    R.ShowDialog();
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Dados\Pontuacao.txt", true))
                    {
                        file.WriteLine(J.Nome);
                        file.WriteLine(J.Score.ToString());
                    }
                    Close();
                }
            }
            else
            {
                int aux = 0;
                for (int i = 0; i < B.Count; i++)
                {
                    if (status == 1)
                    {
                        if (((X[aux] <= 1050) && (X[aux] >= 20)) && ((Y[aux] >= 420) && (Y[aux] <= 600)))
                        {
                            X[aux] += 2;
                            Y[aux] += 2;
                            B[aux].Location = new Point(X[aux], Y[aux]);
                            Update();
                            aux++;
                        }
                        else
                        {
                            status = 0;
                        }
                    }
                    else
                    {
                        if (Y[aux] > 431)
                        {
                            X[aux] -= 2;
                            Y[aux] -= 2;
                            B[aux].Location = new Point(X[aux], Y[aux]);
                            Update();
                            aux++;
                        }
                        else
                        {
                            status = 1;
                        }
                    }
                }
            }
        }

        //Confere as respostas  
        private void button1_Click(object sender, EventArgs e)
        {
            validacao(button1.Tag.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            validacao(button2.Tag.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            validacao(button3.Tag.ToString());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            validacao(button4.Tag.ToString());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            validacao(button5.Tag.ToString());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            validacao(button6.Tag.ToString());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            validacao(button7.Tag.ToString());
        }

        //Valida as respostas

        private void validacao(string s)
        {
            if (s == Line[I])
            {
                J.Score += 1;
                timer1.Stop();
                S.Stop();
                frm_dialogo D = new frm_dialogo(1);
                D.ShowDialog();
                txt_Pontos.Text = J.Score.ToString() + " pts";
                timer1.Start();
                I++;
            }
            else
            {
                timer1.Stop();
                S.Stop();
                frm_dialogo D = new frm_dialogo(int.Parse(Line[I]));
                D.ShowDialog();
                timer1.Start();
                I++;
            }
            tempo1 = 0;

            ///troca de fundo
            if (I < Line.Length)
            {
                if (ind_Image == 0)
                {
                    Correcao C = new Correcao();
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    BackgroundImage = Properties.Resources.mar_novo;
                    C.ShowDialog();
                    S.Play();
                    Update();
                    ind_Image++;

                }
                else if (ind_Image == 1)
                {

                    Correcao C = new Correcao();
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    BackgroundImage = Properties.Resources._4175396;
                    C.ShowDialog();
                    S.Play();
                    Update();
                    ind_Image++;
                }
                else if (ind_Image == 2)
                {
                    Correcao C = new Correcao();
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    BackgroundImage = Properties.Resources._4202419;
                    C.ShowDialog();
                    S.Play();
                    Update();
                    ind_Image++;
                }
                else if (ind_Image == 3)
                {

                    Correcao C = new Correcao();
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    BackgroundImage = Properties.Resources._785;
                    C.ShowDialog();
                    S.Play();
                    Update();
                    ind_Image++;
                }
                else if (ind_Image == 4)
                {

                    Correcao C = new Correcao();
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    BackgroundImage = Properties.Resources._4220362;
                    C.ShowDialog();
                    S.Play();
                    Update();
                    ind_Image++;
                }
                else if (ind_Image == 5)
                {

                    Correcao C = new Correcao();
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    BackgroundImage = Properties.Resources._4209245;
                    C.ShowDialog();
                    S.Play();
                    Update();
                    ind_Image++;
                }
                else if (ind_Image == 6)
                {
                    Correcao C = new Correcao();
                    BackgroundImage = Properties.Resources._4206901;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    C.ShowDialog();
                    S.Play();
                    Update();
                    ind_Image = 0;
                }
            }
        }
    }
}
