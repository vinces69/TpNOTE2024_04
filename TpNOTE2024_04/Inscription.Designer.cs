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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_mdpVerif = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(72, 79);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PlaceholderText = "Nom ";
            this.txt_nom.Size = new System.Drawing.Size(250, 23);
            this.txt_nom.TabIndex = 0;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(72, 124);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.PlaceholderText = "Prénom";
            this.txt_prenom.Size = new System.Drawing.Size(250, 23);
            this.txt_prenom.TabIndex = 1;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(72, 214);
            this.txt_login.Name = "txt_login";
            this.txt_login.PlaceholderText = "Login";
            this.txt_login.Size = new System.Drawing.Size(250, 23);
            this.txt_login.TabIndex = 3;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(72, 258);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PlaceholderText = "Mot de passe";
            this.txt_mdp.Size = new System.Drawing.Size(250, 23);
            this.txt_mdp.TabIndex = 4;
            // 
            // txt_mdpVerif
            // 
            this.txt_mdpVerif.Location = new System.Drawing.Point(72, 302);
            this.txt_mdpVerif.Name = "txt_mdpVerif";
            this.txt_mdpVerif.PlaceholderText = "Confirmer votre mot de passe";
            this.txt_mdpVerif.Size = new System.Drawing.Size(250, 23);
            this.txt_mdpVerif.TabIndex = 5;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(72, 171);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.PlaceholderText = "Adresse mail";
            this.txt_mail.Size = new System.Drawing.Size(250, 23);
            this.txt_mail.TabIndex = 2;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(75, 368);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 6;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(247, 368);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 7;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(149, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inscription";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TpNOTE2024_04.Properties.Resources.FondEcran;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_mdpVerif);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

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