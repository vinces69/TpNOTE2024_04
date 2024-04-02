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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnl_affichage = new System.Windows.Forms.Panel();
            this.lbl_titreMenu = new System.Windows.Forms.Label();
            this.pnl_titre = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TpNOTE2024_04.Properties.Resources.ImageVynil;
            this.pictureBox1.Location = new System.Drawing.Point(1, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TpNOTE2024_04.Properties.Resources.ImageFermer;
            this.pictureBox2.Location = new System.Drawing.Point(1, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TpNOTE2024_04.Properties.Resources.ImageBand;
            this.pictureBox3.Location = new System.Drawing.Point(1, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(228, 139);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pnl_affichage
            // 
            this.pnl_affichage.Location = new System.Drawing.Point(226, 55);
            this.pnl_affichage.Name = "pnl_affichage";
            this.pnl_affichage.Size = new System.Drawing.Size(937, 565);
            this.pnl_affichage.TabIndex = 3;
            // 
            // lbl_titreMenu
            // 
            this.lbl_titreMenu.AutoSize = true;
            this.lbl_titreMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titreMenu.Location = new System.Drawing.Point(235, 9);
            this.lbl_titreMenu.Name = "lbl_titreMenu";
            this.lbl_titreMenu.Size = new System.Drawing.Size(223, 32);
            this.lbl_titreMenu.TabIndex = 4;
            this.lbl_titreMenu.Text = "Gestion des albums";
            // 
            // pnl_titre
            // 
            this.pnl_titre.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_titre.Location = new System.Drawing.Point(1, -1);
            this.pnl_titre.Name = "pnl_titre";
            this.pnl_titre.Size = new System.Drawing.Size(1162, 57);
            this.pnl_titre.TabIndex = 5;
            // 
            // MenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 618);
            this.Controls.Add(this.pnl_titre);
            this.Controls.Add(this.lbl_titreMenu);
            this.Controls.Add(this.pnl_affichage);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuP";
            this.Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel pnl_affichage;
        private Label lbl_titreMenu;
        private Panel pnl_titre;
    }
}