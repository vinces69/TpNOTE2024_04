namespace TpNOTE2024_04
{
    partial class Identification
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_valid = new Button();
            txt_mdp = new TextBox();
            txt_login = new TextBox();
            btn_quitter = new Button();
            lbl_inscription = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_valid
            // 
            btn_valid.Location = new Point(181, 215);
            btn_valid.Name = "btn_valid";
            btn_valid.Size = new Size(75, 23);
            btn_valid.TabIndex = 3;
            btn_valid.Text = "Valider";
            btn_valid.UseVisualStyleBackColor = true;
            btn_valid.Click += btn_valid_Click;
            // 
            // txt_mdp
            // 
            txt_mdp.Location = new Point(181, 164);
            txt_mdp.Name = "txt_mdp";
            txt_mdp.PlaceholderText = "Mot de passe";
            txt_mdp.Size = new Size(257, 23);
            txt_mdp.TabIndex = 2;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(181, 101);
            txt_login.Name = "txt_login";
            txt_login.PlaceholderText = "Login";
            txt_login.Size = new Size(257, 23);
            txt_login.TabIndex = 1;
            // 
            // btn_quitter
            // 
            btn_quitter.Location = new Point(363, 215);
            btn_quitter.Name = "btn_quitter";
            btn_quitter.Size = new Size(75, 23);
            btn_quitter.TabIndex = 9;
            btn_quitter.Text = "Quitter";
            btn_quitter.UseVisualStyleBackColor = true;
            btn_quitter.Click += btn_quitter_Click_1;
            // 
            // lbl_inscription
            // 
            lbl_inscription.AutoSize = true;
            lbl_inscription.BackColor = Color.Transparent;
            lbl_inscription.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_inscription.ForeColor = SystemColors.Desktop;
            lbl_inscription.Location = new Point(468, 286);
            lbl_inscription.Name = "lbl_inscription";
            lbl_inscription.Size = new Size(71, 20);
            lbl_inscription.TabIndex = 10;
            lbl_inscription.Text = "s'inscrire";
            lbl_inscription.Click += lbl_inscription_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(254, 44);
            label1.Name = "label1";
            label1.Size = new Size(105, 27);
            label1.TabIndex = 11;
            label1.Text = "Connexion";
            // 
            // Identification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            BackgroundImage = Properties.Resources.ImageFondPrincipale;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 338);
            Controls.Add(label1);
            Controls.Add(lbl_inscription);
            Controls.Add(btn_quitter);
            Controls.Add(btn_valid);
            Controls.Add(txt_mdp);
            Controls.Add(txt_login);
            Name = "Identification";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_valid;
        private TextBox txt_mdp;
        private TextBox txt_login;
        private Button btn_quitter;
        private Label lbl_inscription;
        private Label label1;
    }
}
