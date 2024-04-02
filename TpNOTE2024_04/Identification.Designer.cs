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
            this.btn_valid = new System.Windows.Forms.Button();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.lbl_inscription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_valid
            // 
            this.btn_valid.Location = new System.Drawing.Point(181, 215);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(75, 23);
            this.btn_valid.TabIndex = 3;
            this.btn_valid.Text = "Valider";
            this.btn_valid.UseVisualStyleBackColor = true;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(181, 164);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PlaceholderText = "Mot de passe";
            this.txt_mdp.Size = new System.Drawing.Size(257, 23);
            this.txt_mdp.TabIndex = 2;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(181, 101);
            this.txt_login.Name = "txt_login";
            this.txt_login.PlaceholderText = "Login";
            this.txt_login.Size = new System.Drawing.Size(257, 23);
            this.txt_login.TabIndex = 1;
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(363, 215);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 9;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            // 
            // lbl_inscription
            // 
            this.lbl_inscription.AutoSize = true;
            this.lbl_inscription.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inscription.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_inscription.Location = new System.Drawing.Point(488, 252);
            this.lbl_inscription.Name = "lbl_inscription";
            this.lbl_inscription.Size = new System.Drawing.Size(53, 15);
            this.lbl_inscription.TabIndex = 10;
            this.lbl_inscription.Text = "s\'inscrire";
            this.lbl_inscription.Click += new System.EventHandler(this.lbl_inscription_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(254, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Connexion";
            // 
            // Identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = global::TpNOTE2024_04.Properties.Resources.FondEcran;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_inscription);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_valid);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_login);
            this.Name = "Identification";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

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
