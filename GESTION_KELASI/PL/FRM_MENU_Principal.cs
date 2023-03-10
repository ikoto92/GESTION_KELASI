using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_KELASI.PL
{
    public partial class FRM_MENU_Principal : Form
    {
        public FRM_MENU_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("Voulez-vous vraiment fermer l'application ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(Dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(Dialog == DialogResult.No)
            {
                this.Activate();
            }         
        }

        private void TSM_créationDunNouveauUtilisateur_Click(object sender, EventArgs e)
        {
            FRM_AjouterUtilisateur CU = new FRM_AjouterUtilisateur();
            CU.Show();
        }

        private void modifierLeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ModiferUtilisateur MU = new FRM_ModiferUtilisateur();
            MU.Show();
        }

        private void TSM_inscription_Click(object sender, EventArgs e)
        {
            if (!PL_Afficher.Controls.Contains(USER_AjouterModifier_Inscription.Instance))
            {
                PL_Afficher.Controls.Add(USER_AjouterModifier_Inscription.Instance);
                USER_AjouterModifier_Inscription.Instance.Dock = DockStyle.Fill;
                USER_AjouterModifier_Inscription.Instance.BringToFront();
            }
            else
            {
                USER_AjouterModifier_Inscription.Instance.BringToFront();
            }
        }

        private void TSM_créerUneNouvelleAnnée_Click(object sender, EventArgs e)
        {
            FRM_AjouterModifier_AnneeScolaire AS = new FRM_AjouterModifier_AnneeScolaire();
            AS.Show();
        }

        private void TSM_créerUneNouvelleClasse_Click(object sender, EventArgs e)
        {
            FRM_AjouterModifier_Classe AC = new FRM_AjouterModifier_Classe();
            AC.Show();
        }

        private void TSM_réinscription_Click(object sender, EventArgs e)
        {
            if (!PL_Afficher.Controls.Contains(USER_AjouterModifier_Reinscription.Instance))
            {
                PL_Afficher.Controls.Add(USER_AjouterModifier_Reinscription.Instance);
                USER_AjouterModifier_Reinscription.Instance.Dock = DockStyle.Fill;
                USER_AjouterModifier_Reinscription.Instance.BringToFront();
            }
            else
            {
                USER_AjouterModifier_Reinscription.Instance.BringToFront();
            }
        }

        private void TSM_créerLePrixDeLinscription_Click(object sender, EventArgs e)
        {
            FRM_AjouterModifier_FraisInscription FI = new FRM_AjouterModifier_FraisInscription();
            FI.Show();
        }

        private void TSM_créerLePrixDeLaRéinscription_Click(object sender, EventArgs e)
        {
            FRM_AjouterModifier_FraisReinscription FR = new FRM_AjouterModifier_FraisReinscription();
            FR.Show();
        }

        private void TSM_accueil_Click(object sender, EventArgs e)
        {
            if (!PL_Afficher.Controls.Contains(USER_Page_Accueil.Instance))
            {
                PL_Afficher.Controls.Add(USER_Page_Accueil.Instance);
                USER_Page_Accueil.Instance.Dock = DockStyle.Fill;
                USER_Page_Accueil.Instance.BringToFront();
            }
            else
            {
                USER_Page_Accueil.Instance.BringToFront();
            }

        }

        private void PL_Afficher_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
