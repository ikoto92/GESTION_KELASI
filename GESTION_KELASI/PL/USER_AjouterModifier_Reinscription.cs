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
    public partial class USER_AjouterModifier_Reinscription : UserControl
    {
        private static USER_AjouterModifier_Reinscription UserReinscriptionEleve;

        public static USER_AjouterModifier_Reinscription Instance
        {
            get
            {
                if (UserReinscriptionEleve == null)
                {
                    UserReinscriptionEleve = new USER_AjouterModifier_Reinscription();
                }
                return UserReinscriptionEleve;
            }
        }

        SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataAdapter singh = new SqlDataAdapter();
        SqlDataReader dr;
        public USER_AjouterModifier_Reinscription()
        {
            InitializeComponent();
            CombAnneeScolaire();
            CombClasse();
        }

        private void Btn_Reinscription_Click(object sender, EventArgs e)
        {
            FRM_AjouterModifier_Reinscription AMR = new FRM_AjouterModifier_Reinscription();
            AMR.Btn_Valider.Visible = false;
            AMR.Show();
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
            SqlCommand cmd = new SqlCommand("SELECT E.codeEt, E.NmEt, E.PrnmEt, E.DtNais, E.LieuNais, E.sexe, E.Nationalite, E.adresEt, R.IDReincription, R.dtreinscription, F.CodeFraisRe, F.fraisReinscription, C.codeclasse, C.classe, A.codeAn, A.anne, R.profil FROM  etudiant E, reinscription R, classe C, anneAcademique A, FraisReinscription F WHERE E.codeEt = R.codeEt AND R.codeclasse = C.codeclasse AND R.codeAn = A.codeAn AND  R.CodeFraisRe = F.CodeFraisRe AND C.classe = @classe AND A.anne = @annee", com);

            cmd.Parameters.AddWithValue("@classe", classe);
            cmd.Parameters.AddWithValue("@annee", annee);
            dr = cmd.ExecuteReader();
            DTGV_Reinscription.Rows.Clear();

            while (dr.Read())
            {
                DTGV_Reinscription.Rows.Add(false, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10), dr.GetValue(11), dr.GetValue(12), dr.GetValue(13), dr.GetValue(14), dr.GetValue(15), dr.GetValue(16));
            }
            com.Close();
        }

        public string SelectVerif()
        {
            int NombreligneSelect = 0;

            for (int i = 0; i < DTGV_Reinscription.Rows.Count; i++)
            {
                if ((bool)DTGV_Reinscription.Rows[i].Cells[0].Value == true)
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

        private void Btn_ModifierEleve_Click(object sender, EventArgs e)
        {
            PL.FRM_AjouterModifier_Reinscription FRMM = new PL.FRM_AjouterModifier_Reinscription();

            if (SelectVerif() == null)
            {
                for (int i = 0; i < DTGV_Reinscription.Rows.Count; i++)
                {
                    if ((bool)DTGV_Reinscription.Rows[i].Cells[0].Value == true)//si chekbox est vrai afficher les information dans le formulaire
                    {
                        string codeEt = DTGV_Reinscription.Rows[i].Cells[1].Value.ToString();

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
                                    FRMM.Txt_IDEtudiant.Text = DTGV_Reinscription.Rows[i].Cells[1].Value.ToString();
                                    FRMM.TxtNomEleve.Text = DTGV_Reinscription.Rows[i].Cells[2].Value.ToString();
                                    FRMM.TxtPrenomEleve.Text = DTGV_Reinscription.Rows[i].Cells[3].Value.ToString();
                                    FRMM.DtmNaissance.Text = DTGV_Reinscription.Rows[i].Cells[4].Value.ToString();
                                    FRMM.TxtLieuNaissance.Text = DTGV_Reinscription.Rows[i].Cells[5].Value.ToString();
                                    FRMM.CbbSexe.Text = DTGV_Reinscription.Rows[i].Cells[6].Value.ToString();
                                    FRMM.TxtNationalite.Text = DTGV_Reinscription.Rows[i].Cells[7].Value.ToString();

                                    FRMM.TxtID_Reinscription.Text = DTGV_Reinscription.Rows[i].Cells[9].Value.ToString();
                                    FRMM.Lbl_Time.Text = DTGV_Reinscription.Rows[i].Cells[10].Value.ToString();

                                    //FRMM.TxTID_FraisReinscrption.Text = DTGV_Reinscription.Rows[i].Cells[9].Value.ToString();
                                    //FRMM.TxtFraisnscription.Text = DTGV_Reinscription.Rows[i].Cells[10].Value.ToString();

                                    FRMM.Cmb_Classe.Text = DTGV_Reinscription.Rows[i].Cells[12].Value.ToString();
                                    FRMM.Cmb_AnneeScolaire.Text = DTGV_Reinscription.Rows[i].Cells[14].Value.ToString();

                                    if (DTGV_Reinscription.Rows[i].Cells[17].Value.ToString() == "Ancien")
                                    {
                                        FRMM.RB_Ancien.Checked = true;
                                    }
                                    if (DTGV_Reinscription.Rows[i].Cells[17].Value.ToString() == "Nouveau")
                                    {
                                        FRMM.RB_Nouveau.Checked = true;
                                    }

                                    FRMM.P_Photo.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        com.Close();
                    }
                }
                FRMM.Btn_Enregistrer.Visible = false;
                FRMM.Lbl_afficher.Text = "MODIFIER LA REINSCRIPTION DE l'ELEVE";
                FRMM.Show();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Photo_Click(object sender, EventArgs e)
        {
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < DTGV_Reinscription.Rows.Count; i++)
                {
                    if ((bool)DTGV_Reinscription.Rows[i].Cells[0].Value == true)
                    {
                        string codeEt = DTGV_Reinscription.Rows[i].Cells[1].Value.ToString();

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

        private void Btn_SupprimerR_Click(object sender, EventArgs e)
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
                    foreach (DataGridViewRow item in DTGV_Reinscription.Rows)
                    {
                        if (bool.Parse(item.Cells[0].Value.ToString()))// si la ligne est cocher
                        {
                            com.Open();

                            // Delete data into inscrire table
                            singh.DeleteCommand = new SqlCommand("DELETE FROM reinscription WHERE IDReincription=@IDReincription", com);
                            singh.DeleteCommand.Parameters.AddWithValue("@IDReincription", item.Cells[9].Value.ToString());
                            singh.DeleteCommand.ExecuteNonQuery();

                            com.Close();
                        }
                    }
                    //actualiser le datagrid view
                    //Actualisedatagrid();
                    //ActualiserDatagrid();
                    MessageBox.Show("Les données son supprimer avec succes", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supprimer est annuler", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
