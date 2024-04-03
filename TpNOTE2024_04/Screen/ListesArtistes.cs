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
    public partial class ListesArtistes : Form
    {
        #region Attributs
        private Artiste artiste;
        private SF SousForm;
        #endregion

        #region Constructeur
        public ListesArtistes()
        {
            InitializeComponent();
            SousForm = new SF((System.Windows.Forms.Application.OpenForms["MenuP"] as MenuP).pnl_affichage);
            artiste = new Artiste();
            dgv_Album.DataSource = artiste.GetListeArtiste(false);
            dgv_Album.Columns[0].Visible = false;
            dgv_Album.Columns[1].HeaderText = "Nom de l'artiste";
            dgv_Album.Columns[1].Width = 550;
            dgv_Album.Columns[2].HeaderText = "Groupe ?";
            dgv_Album.Columns[2].Width = 180;

            cmb_rechercheA.DataSource = artiste.GetListeArtiste(true);
            cmb_rechercheA.DisplayMember = "LABELARTISTE";
            cmb_rechercheA.ValueMember = "IDARTISTE";
        }
        #endregion

        #region Recherche
        private void cmb_rechercheA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgv_Album.DataSource = artiste.GetListeArtiste(false, Convert.ToInt32(cmb_rechercheA.SelectedValue));
            dgv_Album.Columns[0].Visible = false;
            dgv_Album.Columns[1].HeaderText = "Nom de l'artiste";
            dgv_Album.Columns[1].Width = 550;
            dgv_Album.Columns[2].HeaderText = "Groupe ?";
            dgv_Album.Columns[2].Width = 180;
        }
        #endregion

        #region Gestion des boutons
        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            SousForm.openChildForm(new ArtisteAM("Ajouter un artiste"));

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {

            SousForm.openChildForm(new ArtisteAM("Modifier un artiste", Convert.ToInt32(dgv_Album.CurrentRow.Cells[0].Value.ToString()), dgv_Album.CurrentRow.Cells[1].Value.ToString(), Convert.ToBoolean(dgv_Album.CurrentRow.Cells[2].Value.ToString())));

        }
              

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult Valid = MessageBox.Show("Voulez vous supprimer l'artiste :" + dgv_Album.CurrentRow.Cells[1].Value.ToString() + " ?", "Suppression de : " + dgv_Album.CurrentRow.Cells[1].Value.ToString(), MessageBoxButtons.YesNo);
            if (Valid == DialogResult.Yes)
            {
                bool RetourSupp = artiste.DeleteArtiste(Convert.ToInt32(dgv_Album.CurrentRow.Cells[0].Value.ToString()));
                if (RetourSupp)
                    Rafraichir();

            }

        }
        #endregion

        #region Rafraichir DGV
        public void Rafraichir()
        {
            dgv_Album.DataSource = artiste.GetListeArtiste(false);
            dgv_Album.Columns[0].Visible = false;
            dgv_Album.Columns[1].HeaderText = "Nom de l'artiste";
            dgv_Album.Columns[1].Width = 550;
            dgv_Album.Columns[2].HeaderText = "Groupe ?";
            dgv_Album.Columns[2].Width = 180;

            cmb_rechercheA.DataSource = artiste.GetListeArtiste(true);
            cmb_rechercheA.DisplayMember = "LABELARTISTE";
            cmb_rechercheA.ValueMember = "IDARTISTE";
        }
        #endregion
    }
}
