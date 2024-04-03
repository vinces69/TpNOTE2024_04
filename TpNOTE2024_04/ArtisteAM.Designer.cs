namespace TpNOTE2024_04
{
    partial class ArtisteAM
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
            GB_AjoutModif = new GroupBox();
            txt_IdArtiste = new TextBox();
            btn_Annuler = new Button();
            btn_Valider = new Button();
            CHK_Groupe = new CheckBox();
            txt_labelArtiste = new TextBox();
            lbl_artiste = new Label();
            GB_AjoutModif.SuspendLayout();
            SuspendLayout();
            // 
            // GB_AjoutModif
            // 
            GB_AjoutModif.Controls.Add(txt_IdArtiste);
            GB_AjoutModif.Controls.Add(btn_Annuler);
            GB_AjoutModif.Controls.Add(btn_Valider);
            GB_AjoutModif.Controls.Add(CHK_Groupe);
            GB_AjoutModif.Controls.Add(txt_labelArtiste);
            GB_AjoutModif.Controls.Add(lbl_artiste);
            GB_AjoutModif.Location = new Point(192, 49);
            GB_AjoutModif.Name = "GB_AjoutModif";
            GB_AjoutModif.Size = new Size(499, 418);
            GB_AjoutModif.TabIndex = 0;
            GB_AjoutModif.TabStop = false;
            GB_AjoutModif.Text = "groupBox1";
            // 
            // txt_IdArtiste
            // 
            txt_IdArtiste.Location = new Point(179, 73);
            txt_IdArtiste.Name = "txt_IdArtiste";
            txt_IdArtiste.Size = new Size(248, 23);
            txt_IdArtiste.TabIndex = 5;
            txt_IdArtiste.Visible = false;
            // 
            // btn_Annuler
            // 
            btn_Annuler.Location = new Point(352, 349);
            btn_Annuler.Name = "btn_Annuler";
            btn_Annuler.Size = new Size(75, 23);
            btn_Annuler.TabIndex = 4;
            btn_Annuler.Text = "Annuler";
            btn_Annuler.UseVisualStyleBackColor = true;
            btn_Annuler.Click += btn_Annuler_Click;
            // 
            // btn_Valider
            // 
            btn_Valider.Location = new Point(70, 349);
            btn_Valider.Name = "btn_Valider";
            btn_Valider.Size = new Size(75, 23);
            btn_Valider.TabIndex = 3;
            btn_Valider.Text = "Valider";
            btn_Valider.UseVisualStyleBackColor = true;
            btn_Valider.Click += btn_Valider_Click;
            // 
            // CHK_Groupe
            // 
            CHK_Groupe.AutoSize = true;
            CHK_Groupe.CheckAlign = ContentAlignment.MiddleRight;
            CHK_Groupe.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CHK_Groupe.Location = new Point(179, 218);
            CHK_Groupe.Name = "CHK_Groupe";
            CHK_Groupe.Size = new Size(88, 24);
            CHK_Groupe.TabIndex = 2;
            CHK_Groupe.Text = "Groupe ?";
            CHK_Groupe.UseVisualStyleBackColor = true;
            // 
            // txt_labelArtiste
            // 
            txt_labelArtiste.Location = new Point(179, 130);
            txt_labelArtiste.Name = "txt_labelArtiste";
            txt_labelArtiste.Size = new Size(248, 23);
            txt_labelArtiste.TabIndex = 1;
            // 
            // lbl_artiste
            // 
            lbl_artiste.AutoSize = true;
            lbl_artiste.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_artiste.Location = new Point(86, 129);
            lbl_artiste.Name = "lbl_artiste";
            lbl_artiste.Size = new Size(63, 20);
            lbl_artiste.TabIndex = 0;
            lbl_artiste.Text = "Artiste : ";
            // 
            // AlbumAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(921, 526);
            Controls.Add(GB_AjoutModif);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlbumAM";
            Text = "AlbumAM";
            GB_AjoutModif.ResumeLayout(false);
            GB_AjoutModif.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GB_AjoutModif;
        private CheckBox CHK_Groupe;
        private TextBox txt_labelArtiste;
        private Label lbl_artiste;
        private Button btn_Annuler;
        private Button btn_Valider;
        private TextBox txt_IdArtiste;
    }
}