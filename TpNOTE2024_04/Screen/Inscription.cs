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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Identification Id = new Identification();
            Id.Show();
            this.Hide();
            
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {

        }
    }
}
