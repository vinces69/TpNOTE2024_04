namespace TpNOTE2024_04
{
    partial class ListesArtistes
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
            dgv_Album = new DataGridView();
            gb_recherche = new GroupBox();
            cmb_rechercheA = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            btn_ajouter = new Button();
            btn_modifier = new Button();
            btn_supprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Album).BeginInit();
            gb_recherche.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Album
            // 
            dgv_Album.AllowUserToAddRows = false;
            dgv_Album.AllowUserToDeleteRows = false;
            dgv_Album.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Album.Location = new Point(32, 137);
            dgv_Album.Name = "dgv_Album";
            dgv_Album.RowTemplate.Height = 25;
            dgv_Album.Size = new Size(772, 357);
            dgv_Album.TabIndex = 0;
            // 
            // gb_recherche
            // 
            gb_recherche.Controls.Add(cmb_rechercheA);
            gb_recherche.Controls.Add(label1);
            gb_recherche.Location = new Point(519, 22);
            gb_recherche.Name = "gb_recherche";
            gb_recherche.Size = new Size(370, 69);
            gb_recherche.TabIndex = 1;
            gb_recherche.TabStop = false;
            gb_recherche.Text = "Rechercher";
            // 
            // cmb_rechercheA
            // 
            cmb_rechercheA.FormattingEnabled = true;
            cmb_rechercheA.Location = new Point(140, 18);
            cmb_rechercheA.Name = "cmb_rechercheA";
            cmb_rechercheA.Size = new Size(224, 23);
            cmb_rechercheA.TabIndex = 3;
            cmb_rechercheA.SelectionChangeCommitted += cmb_rechercheA_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 21);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Artistes :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(130, 59);
            label3.Name = "label3";
            label3.Size = new Size(203, 32);
            label3.TabIndex = 2;
            label3.Text = "Liste des artistes";
            // 
            // btn_ajouter
            // 
            btn_ajouter.Location = new Point(823, 137);
            btn_ajouter.Name = "btn_ajouter";
            btn_ajouter.Size = new Size(75, 23);
            btn_ajouter.TabIndex = 3;
            btn_ajouter.Text = "Ajouter";
            btn_ajouter.UseVisualStyleBackColor = true;
            btn_ajouter.Click += btn_ajouter_Click;
            // 
            // btn_modifier
            // 
            btn_modifier.Location = new Point(823, 166);
            btn_modifier.Name = "btn_modifier";
            btn_modifier.Size = new Size(75, 23);
            btn_modifier.TabIndex = 4;
            btn_modifier.Text = "Modifier";
            btn_modifier.UseVisualStyleBackColor = true;
            btn_modifier.Click += btn_modifier_Click;
            // 
            // btn_supprimer
            // 
            btn_supprimer.Location = new Point(823, 195);
            btn_supprimer.Name = "btn_supprimer";
            btn_supprimer.Size = new Size(75, 23);
            btn_supprimer.TabIndex = 5;
            btn_supprimer.Text = "Supprimer";
            btn_supprimer.UseVisualStyleBackColor = true;
            btn_supprimer.Click += btn_supprimer_Click;
            // 
            // ListesGroupes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(921, 526);
            Controls.Add(btn_supprimer);
            Controls.Add(btn_modifier);
            Controls.Add(btn_ajouter);
            Controls.Add(label3);
            Controls.Add(gb_recherche);
            Controls.Add(dgv_Album);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListesGroupes";
            Text = "ListesGroupes";
            ((System.ComponentModel.ISupportInitialize)dgv_Album).EndInit();
            gb_recherche.ResumeLayout(false);
            gb_recherche.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gb_recherche;
        private Label label1;
        private Label label3;
        private Button btn_ajouter;
        private Button btn_modifier;
        private Button btn_supprimer;
        private ComboBox cmb_rechercheA;
        private DataGridView dgv_Album;
    }
}