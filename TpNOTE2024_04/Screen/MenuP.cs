﻿using PenduV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpNOTE2024_04.Screen;

namespace TpNOTE2024_04
{
    public partial class MenuP : Form
    {
        SF SousF;
        public MenuP()
        {
            InitializeComponent();
            pnl_titre.SendToBack();
            SousF = new SF(pnl_affichage);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SousF.openChildForm(new ListesAlbums());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult valider = MessageBox.Show("Voulez vous quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valider == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SousF.openChildForm(new ListesArtistes());
        }

        private void pb_Biblio_Click(object sender, EventArgs e)
        {
            SousF.openChildForm(new ListesBibliotheque());
        }
    }
}
