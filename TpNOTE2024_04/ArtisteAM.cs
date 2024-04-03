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
using TpNOTE2024_04.Controllers;

namespace TpNOTE2024_04
{
    public partial class ArtisteAM : Form
    {
        #region Attributs
        Artiste artiste;
        private SF SousForm;
        #endregion

        #region Constructeurs
        public ArtisteAM(String LabelGroupeBox)
        {
            init();
            GB_AjoutModif.Text = LabelGroupeBox;
        }

        public ArtisteAM(String LabelGroupeBox, int IdArtiste, string NomArtiste, bool GroupeArtiste)
        {
            init();
            GB_AjoutModif.Text = LabelGroupeBox;
            txt_IdArtiste.Text = IdArtiste.ToString();
            txt_labelArtiste.Text = NomArtiste;
            CHK_Groupe.Checked = GroupeArtiste;
        }
        public void init()
        {
            InitializeComponent();
            artiste = new Artiste();
            SousForm = new SF((System.Windows.Forms.Application.OpenForms["MenuP"] as MenuP).pnl_affichage);
        }
        #endregion

        #region gestion des evenements
        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
           if (txt_labelArtiste.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom d'artiste");
            }
            else
            {               
                if (txt_IdArtiste.Text == "")
                {
                    artiste.InsertArtiste(txt_labelArtiste.Text, CHK_Groupe.Checked);
                }
                else
                {
                    artiste.UpdateArtiste(Convert.ToInt32(txt_IdArtiste.Text), txt_labelArtiste.Text, CHK_Groupe.Checked);
                }
                ListesArtistes lg = new ListesArtistes();
                SousForm.openChildForm(lg);
                (System.Windows.Forms.Application.OpenForms["ListesGroupes"] as ListesArtistes).Rafraichir();
                this.Close();
            }
        }
        #endregion
    }
}
