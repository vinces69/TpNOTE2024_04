namespace TpNOTE2024_04
{
    partial class Inscription
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
            txt_nom = new TextBox();
            txt_prenom = new TextBox();
            txt_login = new TextBox();
            txt_mdp = new TextBox();
            txt_mdpVerif = new TextBox();
            txt_mail = new TextBox();
            btn_valider = new Button();
            btn_annuler = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_nom
            // 
            txt_nom.Location = new Point(72, 79);
            txt_nom.Name = "txt_nom";
            txt_nom.PlaceholderText = "Nom ";
            txt_nom.Size = new Size(250, 23);
            txt_nom.TabIndex = 0;
            // 
            // txt_prenom
            // 
            txt_prenom.Location = new Point(72, 124);
            txt_prenom.Name = "txt_prenom";
            txt_prenom.PlaceholderText = "Prénom";
            txt_prenom.Size = new Size(250, 23);
            txt_prenom.TabIndex = 1;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(72, 214);
            txt_login.Name = "txt_login";
            txt_login.PlaceholderText = "Login";
            txt_login.Size = new Size(250, 23);
            txt_login.TabIndex = 3;
            // 
            // txt_mdp
            // 
            txt_mdp.Location = new Point(72, 258);
            txt_mdp.Name = "txt_mdp";
            txt_mdp.PlaceholderText = "Mot de passe";
            txt_mdp.Size = new Size(250, 23);
            txt_mdp.TabIndex = 4;
            // 
            // txt_mdpVerif
            // 
            txt_mdpVerif.Location = new Point(72, 302);
            txt_mdpVerif.Name = "txt_mdpVerif";
            txt_mdpVerif.PlaceholderText = "Confirmer votre mot de passe";
            txt_mdpVerif.Size = new Size(250, 23);
            txt_mdpVerif.TabIndex = 5;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(72, 171);
            txt_mail.Name = "txt_mail";
            txt_mail.PlaceholderText = "Adresse mail";
            txt_mail.Size = new Size(250, 23);
            txt_mail.TabIndex = 2;
            // 
            // btn_valider
            // 
            btn_valider.Location = new Point(75, 368);
            btn_valider.Name = "btn_valider";
            btn_valider.Size = new Size(75, 23);
            btn_valider.TabIndex = 6;
            btn_valider.Text = "Valider";
            btn_valider.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            btn_annuler.Location = new Point(247, 368);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(75, 23);
            btn_annuler.TabIndex = 7;
            btn_annuler.Text = "Annuler";
            btn_annuler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(149, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 8;
            label1.Text = "Inscription";
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondEcran;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(394, 433);
            Controls.Add(label1);
            Controls.Add(btn_annuler);
            Controls.Add(btn_valider);
            Controls.Add(txt_mail);
            Controls.Add(txt_mdpVerif);
            Controls.Add(txt_mdp);
            Controls.Add(txt_login);
            Controls.Add(txt_prenom);
            Controls.Add(txt_nom);
            Name = "Inscription";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nom;
        private TextBox txt_prenom;
        private TextBox txt_login;
        private TextBox txt_mdp;
        private TextBox txt_mdpVerif;
        private TextBox txt_mail;
        private Button btn_valider;
        private Button btn_annuler;
        private Label label1;
    }
}