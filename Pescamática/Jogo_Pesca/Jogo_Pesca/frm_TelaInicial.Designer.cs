namespace Jogo_Pesca
{
    partial class frm_Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_inicio = new System.Windows.Forms.Button();
            this.cmd_Sair = new System.Windows.Forms.Button();
            this.cmd_Ranking = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_inicio
            // 
            this.cmd_inicio.BackColor = System.Drawing.Color.Blue;
            this.cmd_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_inicio.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_inicio.Location = new System.Drawing.Point(608, 529);
            this.cmd_inicio.Name = "cmd_inicio";
            this.cmd_inicio.Size = new System.Drawing.Size(188, 75);
            this.cmd_inicio.TabIndex = 0;
            this.cmd_inicio.Text = "INICIAR";
            this.cmd_inicio.UseVisualStyleBackColor = false;
            this.cmd_inicio.Click += new System.EventHandler(this.cmd_inicio_Click);
            // 
            // cmd_Sair
            // 
            this.cmd_Sair.BackColor = System.Drawing.Color.Red;
            this.cmd_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_Sair.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Sair.Location = new System.Drawing.Point(439, 601);
            this.cmd_Sair.Name = "cmd_Sair";
            this.cmd_Sair.Size = new System.Drawing.Size(92, 75);
            this.cmd_Sair.TabIndex = 1;
            this.cmd_Sair.Text = "SAIR";
            this.cmd_Sair.UseVisualStyleBackColor = false;
            this.cmd_Sair.Click += new System.EventHandler(this.cmd_Sair_Click);
            // 
            // cmd_Ranking
            // 
            this.cmd_Ranking.BackColor = System.Drawing.Color.Aqua;
            this.cmd_Ranking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_Ranking.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Ranking.Location = new System.Drawing.Point(860, 601);
            this.cmd_Ranking.Name = "cmd_Ranking";
            this.cmd_Ranking.Size = new System.Drawing.Size(151, 73);
            this.cmd_Ranking.TabIndex = 2;
            this.cmd_Ranking.Text = "RANKING";
            this.cmd_Ranking.UseVisualStyleBackColor = false;
            this.cmd_Ranking.Click += new System.EventHandler(this.cmd_Ranking_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(608, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "CRÉDITOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_Pesca.Properties.Resources.WhatsApp_Image_2020_11_20_at_14_26_55;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 758);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd_Ranking);
            this.Controls.Add(this.cmd_Sair);
            this.Controls.Add(this.cmd_inicio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Inicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_inicio;
        private System.Windows.Forms.Button cmd_Sair;
        private System.Windows.Forms.Button cmd_Ranking;
        private System.Windows.Forms.Button button1;
    }
}

