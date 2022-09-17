
namespace Jogo_Pesca
{
    partial class FrmPontuacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_Sair = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.Lt_1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jogo_Pesca.Properties.Resources.Rectangle_12;
            this.pictureBox1.Location = new System.Drawing.Point(1031, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Jogo_Pesca.Properties.Resources._1603847;
            this.pictureBox2.Location = new System.Drawing.Point(331, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(549, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "RANKING";
            // 
            // cmd_Sair
            // 
            this.cmd_Sair.BackColor = System.Drawing.Color.Red;
            this.cmd_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd_Sair.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Sair.Location = new System.Drawing.Point(12, 654);
            this.cmd_Sair.Name = "cmd_Sair";
            this.cmd_Sair.Size = new System.Drawing.Size(129, 55);
            this.cmd_Sair.TabIndex = 4;
            this.cmd_Sair.Text = "VOLTAR";
            this.cmd_Sair.UseVisualStyleBackColor = false;
            this.cmd_Sair.Click += new System.EventHandler(this.cmd_Sair_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Lt_1
            // 
            this.Lt_1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lt_1.HideSelection = false;
            this.Lt_1.Location = new System.Drawing.Point(427, 386);
            this.Lt_1.Name = "Lt_1";
            this.Lt_1.Size = new System.Drawing.Size(356, 297);
            this.Lt_1.TabIndex = 6;
            this.Lt_1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmPontuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_Pesca.Properties.Resources.Jogo;
            this.ClientSize = new System.Drawing.Size(1330, 709);
            this.ControlBox = false;
            this.Controls.Add(this.Lt_1);
            this.Controls.Add(this.cmd_Sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPontuacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPontuacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_Sair;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ListView Lt_1;
    }
}