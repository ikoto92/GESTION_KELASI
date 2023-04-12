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
using static System.Windows.Forms.LinkLabel;
using System.IO;

namespace GESTION_KELASI.PL
{
    public partial class USER_AjouterModifier_Inscription : UserControl
    {
        private static USER_AjouterModifier_Inscription UserInscriptionEtudiant;

        public static USER_AjouterModifier_Inscription Instance
        {
            get
            {
                if (UserInscriptionEtudiant == null)
                {
                    UserInscriptionEtudiant = new USER_AjouterModifier_Inscription();
                }
                return UserInscriptionEtudiant;
            }
        }

        SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataAdapter singh = new SqlDataAdapter();
        SqlDataReader dr;
        public USER_AjouterModifier_Inscription()
        {
            InitializeComponent();
            CombAnneeScolaire();
            CombClasse();
        }

        private void Btn_Inscription_Click(object sender, EventArgs e)
        {
            FRM_AjouterModifier_Inscription AI = new FRM_AjouterModifier_Inscription();
            AI.Btn_Valider.Visible = false;
            AI.Show();
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

        private void ActualiserDatagrid()
        {
            // Réexécuter la requête de base de données qui remplit le DataGridView
            singh.SelectCommand = new SqlCommand("SELECT E.codeEt, E.NmEt, E.PrnmEt, E.DtNais, E.LieuNais, E.sexe, E.Nationalite, E.adresEt, I.IDincription, I.dtInscription, C.codeclasse, C.classe, A.codeAn, A.anne, D.codeDo, D.Bulletin, D.Diplome, D.Photo, PS.codeInfScol, PS.DipEntre, PS.AnEt, PS.DerNivEt, PS.DerEstScol, PS.Profil, T.codeTuteur, T.NmPRPere, T.NmPrMere, T.AdreParent, T.Tuteur, T.NumTuteur, T.lieuParent FROM etudiant E, inscrire I, classe C, anneAcademique A, Parcourscolaires PS, Dossier D, tuteur T WHERE E.codeEt = I.codeEt AND I.codeclasse = C.codeclasse AND I.codeAn = A.codeAn AND E.codeInfScol = PS.codeInfScol AND E.codeDo = D.codeDo AND E.codeTuteur = T.codeTuteur ", com);
            
            try
            {
                com.Open();
                singh.SelectCommand.ExecuteNonQuery();
                dr = singh.SelectCommand.ExecuteReader();
                Dtg_Inscrire.Rows.Clear();

                while (dr.Read())
                {
                    Dtg_Inscrire.Rows.Add(false, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10), dr.GetValue(11), dr.GetValue(12), dr.GetValue(13), dr.GetValue(14), dr.GetValue(15), dr.GetValue(16), dr.GetValue(17), dr.GetValue(18), dr.GetValue(19), dr.GetValue(20), dr.GetValue(21), dr.GetValue(22), dr.GetValue(23), dr.GetValue(24), dr.GetValue(25), dr.GetValue(26), dr.GetValue(27), dr.GetValue(28), dr.GetValue(29), dr.GetValue(30));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
            com.Close();
        }

        private void Btn_Afficher_Click(object sender, EventArgs e)
        {
            string classe = Cmb_Classe.Text;
            string annee = Cmb_AnneeScolaire.Text;

            com.Open();

            SqlCommand cmd = new SqlCommand("SELECT E.codeEt, E.NmEt, E.PrnmEt, E.DtNais, E.LieuNais, E.sexe, E.Nationalite, E.adresEt, I.IDincription, I.dtInscription, C.codeclasse, C.classe, A.codeAn, A.anne, D.codeDo, D.Bulletin, D.Diplome, D.Photo, PS.codeInfScol, PS.DipEntre, PS.AnEt, PS.DerNivEt, PS.DerEstScol, PS.Profil, T.codeTuteur, T.NmPRPere, T.NmPrMere, T.AdreParent, T.Tuteur, T.NumTuteur, T.lieuParent FROM etudiant E, inscrire I, classe C, anneAcademique A, Parcourscolaires PS, Dossier D, tuteur T WHERE E.codeEt = I.codeEt AND I.codeclasse = C.codeclasse AND I.codeAn = A.codeAn AND E.codeInfScol = PS.codeInfScol AND E.codeDo = D.codeDo AND E.codeTuteur = T.codeTuteur AND C.classe = @classe AND A.anne = @annee", com);
            cmd.Parameters.AddWithValue("@classe", classe);
            cmd.Parameters.AddWithValue("@annee", annee);
            dr = cmd.ExecuteReader();
            Dtg_Inscrire.Rows.Clear();

            while (dr.Read())
            {
                Dtg_Inscrire.Rows.Add(false, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10), dr.GetValue(11), dr.GetValue(12), dr.GetValue(13), dr.GetValue(14), dr.GetValue(15), dr.GetValue(16), dr.GetValue(17), dr.GetValue(18), dr.GetValue(19), dr.GetValue(20), dr.GetValue(21), dr.GetValue(22), dr.GetValue(23), dr.GetValue(24), dr.GetValue(25), dr.GetValue(26), dr.GetValue(27), dr.GetValue(28), dr.GetValue(29), dr.GetValue(30));
            }
            com.Close();

        }

        public string SelectVerif()
        {
            int NombreligneSelect = 0;

            for (int i = 0; i < Dtg_Inscrire.Rows.Count; i++)
            {
                if ((bool)Dtg_Inscrire.Rows[i].Cells[0].Value == true)
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
                for (int i = 0; i < Dtg_Inscrire.Rows.Count; i++)
                {
                    if ((bool)Dtg_Inscrire.Rows[i].Cells[0].Value == true)
                    {
                        string codeEt = Dtg_Inscrire.Rows[i].Cells[1].Value.ToString();

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
       
        private void Btn_ModifierEleve_Click(object sender, EventArgs e)
        {
            PL.FRM_AjouterModifier_Inscription FRMM = new PL.FRM_AjouterModifier_Inscription();

            if (SelectVerif() == null)
            {
                for (int i = 0; i < Dtg_Inscrire.Rows.Count; i++)
                {
                    if ((bool)Dtg_Inscrire.Rows[i].Cells[0].Value == true)//si chekbox est vrai afficher les information dans le formulaire
                    {
                        string codeEt = Dtg_Inscrire.Rows[i].Cells[1].Value.ToString();

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
                                    FRMM.Txt_IDEtudiant.Text = Dtg_Inscrire.Rows[i].Cells[1].Value.ToString();
                                    FRMM.TxtNomEleve.Text = Dtg_Inscrire.Rows[i].Cells[2].Value.ToString();
                                    FRMM.TxtPrenomEleve.Text = Dtg_Inscrire.Rows[i].Cells[3].Value.ToString();
                                    FRMM.DtmNaissance.Text = Dtg_Inscrire.Rows[i].Cells[4].Value.ToString();
                                    FRMM.TxtLieuNaissance.Text = Dtg_Inscrire.Rows[i].Cells[5].Value.ToString();
                                    FRMM.CbbSexe.Text = Dtg_Inscrire.Rows[i].Cells[6].Value.ToString();
                                    FRMM.TxtNationalite.Text = Dtg_Inscrire.Rows[i].Cells[7].Value.ToString();
                                    FRMM.TxtAdressParent.Text = Dtg_Inscrire.Rows[i].Cells[8].Value.ToString();
                                    // FRMM.ByteImage = Dtg_Inscrire.Rows[i].Cells[1].Value.ToString();
                                    FRMM.Txt_IDInscription.Text = Dtg_Inscrire.Rows[i].Cells[9].Value.ToString();
                                    FRMM.Lbl_Time.Text = Dtg_Inscrire.Rows[i].Cells[10].Value.ToString();
                                    FRMM.Cmb_Classe.Text = Dtg_Inscrire.Rows[i].Cells[12].Value.ToString();
                                    FRMM.Cmb_AnneeScolaire.Text = Dtg_Inscrire.Rows[i].Cells[14].Value.ToString();
                                    FRMM.TxtID_Dossier.Text = Dtg_Inscrire.Rows[i].Cells[15].Value.ToString();
                                    
                                    string bulletin = Dtg_Inscrire.Rows[i].Cells[16].Value.ToString(); 
                                    string diplome = Dtg_Inscrire.Rows[i].Cells[17].Value.ToString(); 
                                    string photo = Dtg_Inscrire.Rows[i].Cells[18].Value.ToString();

                                    FRMM.Cb_Bulletin.Checked = bulletin == "Oui" ? true : false;
                                    FRMM.Cb_Diplome.Checked = diplome == "Oui" ? true : false;
                                    FRMM.Cb_Photo.Checked = photo == "Oui" ? true : false;
                                    
                                    FRMM.Txt_IDParScolaire.Text = Dtg_Inscrire.Rows[i].Cells[19].Value.ToString();
                                    FRMM.TxtDernierDipl.Text = Dtg_Inscrire.Rows[i].Cells[20].Value.ToString();
                                    FRMM.TxtAnnee.Text = Dtg_Inscrire.Rows[i].Cells[21].Value.ToString();
                                    FRMM.TxtDernierNivScol.Text = Dtg_Inscrire.Rows[i].Cells[22].Value.ToString();
                                    FRMM.TxtDernierEstScolaire.Text = Dtg_Inscrire.Rows[i].Cells[23].Value.ToString();

                                    if (Dtg_Inscrire.Rows[i].Cells[24].Value.ToString() == "Ancien")
                                    {
                                        FRMM.RB_Ancien.Checked = true;
                                    }
                                    if (Dtg_Inscrire.Rows[i].Cells[24].Value.ToString() == "Nouveau")
                                    {
                                        FRMM.RB_Nouveau.Checked = true;
                                    }

                                    //FRMM.Profil = Dtg_Inscrire.Rows[i].Cells[24].Value.ToString();
                                    FRMM.Txt_IDTuteur.Text = Dtg_Inscrire.Rows[i].Cells[25].Value.ToString();
                                    FRMM.TxtNomPere.Text = Dtg_Inscrire.Rows[i].Cells[26].Value.ToString();
                                    FRMM.TxtNomMere.Text = Dtg_Inscrire.Rows[i].Cells[27].Value.ToString();
                                    FRMM.TxtAdressParent.Text = Dtg_Inscrire.Rows[i].Cells[28].Value.ToString();
                                    FRMM.TxtTuteur.Text = Dtg_Inscrire.Rows[i].Cells[29].Value.ToString();
                                    FRMM.TxtTelephone.Text = Dtg_Inscrire.Rows[i].Cells[30].Value.ToString();
                                    FRMM.TxtLienParente.Text = Dtg_Inscrire.Rows[i].Cells[31].Value.ToString();
                                    
                                    FRMM.P_Photo.Image = Image.FromStream(ms);
                                }
                            }                      
                        }               
                        com.Close();
                    }
                }
                FRMM.Btn_Enregistrer.Visible = false;
                FRMM.Lb_AfficherI.Text = "MODIFIER l'INSCRIPTION DE l'ELEVE";
                FRMM.Show();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }             
        }

        private void Btn_SupprimerI_Click(object sender, EventArgs e)
        {
            if (SelectVerif() == "Selectionner")
            {
                MessageBox.Show(SelectVerif(), "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                DialogResult DR = MessageBox.Show("Voulez-vous vraiment supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    //verification de combien de ligne selectionner
                    foreach (DataGridViewRow item in Dtg_Inscrire.Rows)
                    {
                        if (bool.Parse(item.Cells[0].Value.ToString()))// si la ligne est cocher
                        {
                            com.Open();

                            // Delete data into inscrire table
                            singh.DeleteCommand = new SqlCommand("DELETE FROM inscrire WHERE IDincription = @IDincription", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@IDincription", item.Cells[9].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();

                            // Delete data into etudiant table
                            singh.DeleteCommand = new SqlCommand("DELETE FROM etudiant WHERE codeEt = @codeEt", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@codeEt", item.Cells[1].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();

                            // Delete data into Tuteur table
                            singh.DeleteCommand = new SqlCommand("DELETE FROM tuteur WHERE codeTuteur = @codeTuteur", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@codeTuteur", item.Cells[25].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();

                            // Delete data into Dossier fourni table
                            singh.DeleteCommand = new SqlCommand("DELETE FROM Dossier WHERE codeDo = @codeDo", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@codeDo", item.Cells[15].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();

                            // Delete data into Parcourscolaires table
                            singh.DeleteCommand = new SqlCommand("DELETE FROM Parcourscolaires WHERE codeInfScol = @codeInfScol", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@codeInfScol", item.Cells[19].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();
                            
                            com.Close();
                        }                
                    }
                    //actualiser le datagrid view
                    //Actualisedatagrid();
                    ActualiserDatagrid();
                    MessageBox.Show("Les données son supprimer avec succes", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supprimer est annuler", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Btn_ImprimerTout_Click(object sender, EventArgs e)
        {

        }
    }
}
