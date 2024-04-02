using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;



namespace TpNOTE2024_04
{
    public partial class Identification : Form
    {
        public Identification()
        {
            InitializeComponent();

        }

        private void lbl_inscription_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
            this.Hide();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == "" || txt_mdp.Text == "")
            {
                if (txt_login.Text == "")
                {
                    MessageBox.Show("Champs vide", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_login.Focus();
                }
                if(txt_mdp.Text == "")
                {
                    MessageBox.Show("Champs vide", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (txt_login.Text != "")
                    txt_login.Focus();
                }
            }
            else
            {
                MenuP EcranP = new MenuP();
                EcranP.Show();
                this.Hide();
            }
        }

       
    }
}
