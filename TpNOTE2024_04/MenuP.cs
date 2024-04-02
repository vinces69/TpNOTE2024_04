using PenduV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Close();
        }
    }
}
