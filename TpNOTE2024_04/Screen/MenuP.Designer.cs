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
            pb_Album = new PictureBox();
            pb_Exit = new PictureBox();
            pb_Artistes = new PictureBox();
            pnl_affichage = new Panel();
            lbl_titreMenu = new Label();
            pnl_titre = new Panel();
            pb_Biblio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_Album).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Artistes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Biblio).BeginInit();
            SuspendLayout();
            // 
            // pb_Album
            // 
            pb_Album.Image = Properties.Resources.ImageVynil;
            pb_Album.Location = new Point(-1, 196);
            pb_Album.Name = "pb_Album";
            pb_Album.Size = new Size(227, 139);
            pb_Album.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Album.TabIndex = 0;
            pb_Album.TabStop = false;
            pb_Album.Click += pictureBox1_Click;
            // 
            // pb_Exit
            // 
            pb_Exit.Image = Properties.Resources.ImageFermer;
            pb_Exit.Location = new Point(1, 478);
            pb_Exit.Name = "pb_Exit";
            pb_Exit.Size = new Size(226, 139);
            pb_Exit.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Exit.TabIndex = 1;
            pb_Exit.TabStop = false;
            pb_Exit.Click += pictureBox2_Click;
            // 
            // pb_Artistes
            // 
            pb_Artistes.Image = Properties.Resources.ImageBand;
            pb_Artistes.Location = new Point(-1, 332);
            pb_Artistes.Name = "pb_Artistes";
            pb_Artistes.Size = new Size(227, 139);
            pb_Artistes.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Artistes.TabIndex = 2;
            pb_Artistes.TabStop = false;
            pb_Artistes.Click += pictureBox3_Click;
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
            // pb_Biblio
            // 
            pb_Biblio.Image = Properties.Resources.meuble_vinyles;
            pb_Biblio.Location = new Point(-2, 55);
            pb_Biblio.Name = "pb_Biblio";
            pb_Biblio.Size = new Size(228, 139);
            pb_Biblio.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Biblio.TabIndex = 6;
            pb_Biblio.TabStop = false;
            pb_Biblio.Click += pb_Biblio_Click;
            // 
            // MenuP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 618);
            Controls.Add(pb_Biblio);
            Controls.Add(pnl_titre);
            Controls.Add(lbl_titreMenu);
            Controls.Add(pnl_affichage);
            Controls.Add(pb_Artistes);
            Controls.Add(pb_Exit);
            Controls.Add(pb_Album);
            Name = "MenuP";
            Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)pb_Album).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Artistes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Biblio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_Album;
        private PictureBox pb_Exit;
        private PictureBox pb_Artistes;
        private Label lbl_titreMenu;
        private Panel pnl_titre;
        public Panel pnl_affichage;
        private PictureBox pb_Biblio;
    }
}