namespace TpNOTE2024_04
{
    partial class ListesGroupes
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
            this.dgv_Album = new System.Windows.Forms.DataGridView();
            this.gb_recherche = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Album)).BeginInit();
            this.gb_recherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Album
            // 
            this.dgv_Album.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Album.Location = new System.Drawing.Point(32, 137);
            this.dgv_Album.Name = "dgv_Album";
            this.dgv_Album.RowTemplate.Height = 25;
            this.dgv_Album.Size = new System.Drawing.Size(857, 357);
            this.dgv_Album.TabIndex = 0;
            // 
            // gb_recherche
            // 
            this.gb_recherche.Controls.Add(this.label1);
            this.gb_recherche.Controls.Add(this.textBox1);
            this.gb_recherche.Location = new System.Drawing.Point(519, 22);
            this.gb_recherche.Name = "gb_recherche";
            this.gb_recherche.Size = new System.Drawing.Size(370, 69);
            this.gb_recherche.TabIndex = 1;
            this.gb_recherche.TabStop = false;
            this.gb_recherche.Text = "Rechercher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artistes :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(130, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liste des artistes";
            // 
            // ListesGroupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(921, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_recherche);
            this.Controls.Add(this.dgv_Album);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListesGroupes";
            this.Text = "ListesGroupes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Album)).EndInit();
            this.gb_recherche.ResumeLayout(false);
            this.gb_recherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_Album;
        private GroupBox gb_recherche;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
    }
}