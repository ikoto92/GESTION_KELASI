using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace GESTION_KELASI.PL
{
    public partial class FRM_SelectReinscription : Form
    {
        SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataAdapter singh = new SqlDataAdapter();
        SqlDataReader dr;
        public FRM_SelectReinscription()
        {
            InitializeComponent();
            CombAnneeScolaire();
            CombClasse();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtRecherche_Enter(object sender, EventArgs e)
        {
            if (TxtRecherche.Text == "RECHERCHE")
            {
                TxtRecherche.Text = "";
                TxtRecherche.ForeColor = Color.Blue;
            }
        }

        private void TxtRecherche_Leave(object sender, EventArgs e)
        {
            if (TxtRecherche.Text == "")
            {
                TxtRecherche.Text = "RECHERCHE";
                TxtRecherche.ForeColor = Color.Black;
            }
        }

        BindingSource bsAnneAcademique = new BindingSource();
        BindingSource bsClasses = new BindingSource();
        private void CombAnneeScolaire()
        {
            com.Open();

            SqlCommand cmd = com.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT codeAn, anne FROM anneAcademique";
            //Ajout de la sélection des colonnes codeAn et anne
            cmd.Connection = com;
            SqlDataReader reader = cmd.ExecuteReader();
            bsAnneAcademique.DataSource = reader;
            Cmb_AnneeScolaire.DataSource = bsAnneAcademique;
            //ajout de la source de donnée et les valeur et affichage pour le combobox
            Cmb_AnneeScolaire.DisplayMember = "anne";
            Cmb_AnneeScolaire.ValueMember = "codeAn";
            com.Close();
        }



        /////////////////
        /// Combobox Classe
        ///
        private void CombClasse()
        {
            com.Open();

            SqlCommand cmd = com.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT codeclasse, classe FROM classe";
            //Ajout de la sélection des colonnes codeAn et anne
            cmd.Connection = com;
            SqlDataReader reader = cmd.ExecuteReader();
            bsClasses.DataSource = reader;
            Cmb_Classe.DataSource = bsClasses;
            //ajout de la source de donnée et les valeur et affichage pour le combobox
            Cmb_Classe.DisplayMember = "classe";
            Cmb_Classe.ValueMember = "codeclasse";

            com.Close();
        }

        private void Btn_Afficher_Click(object sender, EventArgs e)
        {
            // Réexécuter la requête de base de données qui remplit le DataGridView
            string classe = Cmb_Classe.Text;
            string annee = Cmb_AnneeScolaire.Text;

            com.Open();
            SqlCommand cmd = new SqlCommand("SELECT E.codeEt, E.NmEt, E.PrnmEt, E.DtNais, E.LieuNais, E.sexe, E.Nationalite, E.adresEt, C.codeclasse, C.classe, A.codeAn, A.anne FROM  etudiant E, inscrire I, classe C, anneAcademique A WHERE E.codeEt = I.codeEt AND I.codeclasse = C.codeclasse AND I.codeAn = A.codeAn AND C.classe = @classe AND A.anne = @annee", com);

            cmd.Parameters.AddWithValue("@classe", classe);
            cmd.Parameters.AddWithValue("@annee", annee);
            dr = cmd.ExecuteReader();
            DTGV_SELECTReinscription.Rows.Clear();

            while (dr.Read())
            {
                DTGV_SELECTReinscription.Rows.Add(false, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10), dr.GetValue(11));
            }
            com.Close();
        }
        public string SelectVerif()
        {
            int NombreligneSelect = 0;

            for (int i = 0; i < DTGV_SELECTReinscription.Rows.Count; i++)
            {
                if ((bool)DTGV_SELECTReinscription.Rows[i].Cells[0].Value == true)
                {
                    NombreligneSelect++;
                }
            }
            if (NombreligneSelect == 0)
            {
                return "Selectionné une seule ligne que vous voulez modifier";
            }
            if (NombreligneSelect > 1)
            {
                return "Selectionné une seule ligne pour modifier";
            }
            return null;
        }

        private void Btn_Photo_Click(object sender, EventArgs e)
        {
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < DTGV_SELECTReinscription.Rows.Count; i++)
                {
                    if ((bool)DTGV_SELECTReinscription.Rows[i].Cells[0].Value == true)
                    {
                        string codeEt = DTGV_SELECTReinscription.Rows[i].Cells[1].Value.ToString();

                        com.Open();

                        SqlCommand cmd = new SqlCommand("SELECT photo, NmEt, PrnmEt FROM etudiant WHERE codeEt = @codeEt", com);
                        cmd.Parameters.AddWithValue("@codeEt", codeEt);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["photo"];
                            string nom = reader["NmEt"].ToString();
                            string prenom = reader["PrnmEt"].ToString();

                            if (imageData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    PL.FRM_Affiche_Photo FAP = new PL.FRM_Affiche_Photo();
                                    FAP.PT_AffichePhoto.Image = Image.FromStream(ms);
                                    FAP.LB_AffichePhoto.Text = nom + " " + prenom;
                                    FAP.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Aucune photo trouvée pour l'étudiant sélectionné");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucune information trouvée pour l'étudiant sélectionné");
                        }
                        com.Close();
                    }
                }
            }
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            PL.FRM_AjouterModifier_Reinscription FRMM = new PL.FRM_AjouterModifier_Reinscription();

            if (SelectVerif() == null)
            {
                for (int i = 0; i < DTGV_SELECTReinscription.Rows.Count; i++)
                {
                    if ((bool)DTGV_SELECTReinscription.Rows[i].Cells[0].Value == true)//si chekbox est vrai afficher les information dans le formulaire
                    {
                        string codeEt = DTGV_SELECTReinscription.Rows[i].Cells[1].Value.ToString();

                        com.Open();

                        SqlCommand cmd = new SqlCommand("SELECT photo FROM etudiant WHERE codeEt = @codeEt", com);
                        cmd.Parameters.AddWithValue("@codeEt", codeEt);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["photo"];
                            if (imageData != null)
                            {

                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    FRMM.Txt_IDEtudiant.Text = DTGV_SELECTReinscription.Rows[i].Cells[1].Value.ToString();
                                    FRMM.TxtNomEleve.Text = DTGV_SELECTReinscription.Rows[i].Cells[2].Value.ToString();
                                    FRMM.TxtPrenomEleve.Text = DTGV_SELECTReinscription.Rows[i].Cells[3].Value.ToString();
                                    FRMM.DtmNaissance.Text = DTGV_SELECTReinscription.Rows[i].Cells[4].Value.ToString();
                                    FRMM.TxtLieuNaissance.Text = DTGV_SELECTReinscription.Rows[i].Cells[5].Value.ToString();
                                    FRMM.CbbSexe.Text = DTGV_SELECTReinscription.Rows[i].Cells[6].Value.ToString();
                                    FRMM.TxtNationalite.Text = DTGV_SELECTReinscription.Rows[i].Cells[7].Value.ToString();

                                    FRMM.P_Photo.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        com.Close();
                    }
                }
                FRMM.Btn_Valider.Visible = false;
                FRMM.Lbl_afficher.Text = "MODIFIER LA REINSCRIPTION DE l'ELEVE";
                
                FRMM.Show();
                Close();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = TxtRecherche.Text.Trim().ToLower();

            foreach (DataGridViewRow row in DTGV_SELECTReinscription.Rows)
            {
                string nom = row.Cells["Column3"].Value.ToString().ToLower();
                string prenom = row.Cells["Column4"].Value.ToString().ToLower();

                if (nom.Contains(recherche) || prenom.Contains(recherche))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}
