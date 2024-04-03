﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenduV2.Model
{
    public class SF
    {
        #region Attributs
        public Panel PanelSousFormlaire;
        public Form activeForm = null;
        #endregion

        #region Constructeur
        public SF(Panel panelenvoit)
        {
            PanelSousFormlaire = panelenvoit;
        }
        #endregion

        #region Méthodes
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            PanelSousFormlaire.Controls.Add(formEnfant);
            PanelSousFormlaire.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }
        #endregion
    }
}
