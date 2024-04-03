namespace TpNOTE2024_04
{
    partial class MenuP
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pnl_affichage = new Panel();
            lbl_titreMenu = new Label();
            pnl_titre = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImageVynil;
            pictureBox1.Location = new Point(1, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ImageFermer;
            pictureBox2.Location = new Point(1, 345);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 139);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ImageBand;
            pictureBox3.Location = new Point(1, 200);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(228, 139);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pnl_affichage
            // 
            pnl_affichage.Location = new Point(226, 55);
            pnl_affichage.Name = "pnl_affichage";
            pnl_affichage.Size = new Size(937, 565);
            pnl_affichage.TabIndex = 3;
            // 
            // lbl_titreMenu
            // 
            lbl_titreMenu.AutoSize = true;
            lbl_titreMenu.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titreMenu.Location = new Point(235, 9);
            lbl_titreMenu.Name = "lbl_titreMenu";
            lbl_titreMenu.Size = new Size(223, 32);
            lbl_titreMenu.TabIndex = 4;
            lbl_titreMenu.Text = "Gestion des albums";
            // 
            // pnl_titre
            // 
            pnl_titre.BackColor = Color.Firebrick;
            pnl_titre.Location = new Point(1, -1);
            pnl_titre.Name = "pnl_titre";
            pnl_titre.Size = new Size(1162, 57);
            pnl_titre.TabIndex = 5;
            // 
            // MenuP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 618);
            Controls.Add(pnl_titre);
            Controls.Add(lbl_titreMenu);
            Controls.Add(pnl_affichage);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "MenuP";
            Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbl_titreMenu;
        private Panel pnl_titre;
        public Panel pnl_affichage;
    }
}