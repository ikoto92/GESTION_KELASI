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
    public partial class FRM_Select_Reinscription : Form
    {

        SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataAdapter singh = new SqlDataAdapter();
        SqlDataReader dr;
        public FRM_Select_Reinscription()
        {
            InitializeComponent();

            CombAnneeScolaire();
            CombClasse();
        }

        public string SelectVerif()
        {
            int NombreligneSelect = 0;

            for (int i = 0; i < DTG_SelectReinscription.Rows.Count; i++)
            {
                if ((bool)DTG_SelectReinscription.Rows[i].Cells[0].Value == true)
                {
                    NombreligneSelect++;
                }
            }
            if (NombreligneSelect == 0)
            {
                return "Selectionné une seule ligne que vous voulez affiché, modifier ou supprimer";
            }
            if (NombreligneSelect > 1)
            {
                return "Selectionné une seule ligne pour modifier";
            }
            return null;
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

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Afficher_Click(object sender, EventArgs e)
        {
            string classe = Cmb_Classe.Text;
            string annee = Cmb_AnneeScolaire.Text;

            com.Open();
            SqlCommand cmd = new SqlCommand("SELECT E.codeEt, E.NmEt, E.PrnmEt, E.DtNais, E.LieuNais, E.sexe, E.Nationalite, E.adresEt, C.codeclasse, C.classe, A.codeAn, A.anne FROM etudiant E, inscrire I, classe C, anneAcademique A WHERE E.codeEt = I.codeEt AND I.codeclasse = C.codeclasse AND I.codeAn = A.codeAn AND C.classe = @classe AND A.anne = @annee", com);
            cmd.Parameters.AddWithValue("@classe", classe);
            cmd.Parameters.AddWithValue("@annee", annee);
            dr = cmd.ExecuteReader();
            DTG_SelectReinscription.Rows.Clear();

            while (dr.Read())
            {
                DTG_SelectReinscription.Rows.Add(false, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10), dr.GetValue(11));
            }
            com.Close();
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            PL.FRM_AjouterModifier_Reinscription FRMM = new PL.FRM_AjouterModifier_Reinscription();

            if (SelectVerif() == null)
            {
                for (int i = 0; i < DTG_SelectReinscription.Rows.Count; i++)
                {
                    if ((bool)DTG_SelectReinscription.Rows[i].Cells[0].Value == true)//si chekbox est vrai afficher les information dans le formulaire
                    {
                        string codeEt = DTG_SelectReinscription.Rows[i].Cells[1].Value.ToString();

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
                                    FRMM.TxtID_Etudiant.Text = DTG_SelectReinscription.Rows[i].Cells[1].Value.ToString();
                                    FRMM.TxtNom_Etudiant.Text = DTG_SelectReinscription.Rows[i].Cells[2].Value.ToString();
                                    FRMM.TxtPrenom_Etudiant.Text = DTG_SelectReinscription.Rows[i].Cells[3].Value.ToString();
                                    FRMM.DTP_DateNaissance.Text = DTG_SelectReinscription.Rows[i].Cells[4].Value.ToString();
                                    FRMM.Txt_LieuNaissance.Text = DTG_SelectReinscription.Rows[i].Cells[5].Value.ToString();
                                    FRMM.Cmb_Sexe.Text = DTG_SelectReinscription.Rows[i].Cells[6].Value.ToString();
                                    FRMM.Txt_Nationalite.Text = DTG_SelectReinscription.Rows[i].Cells[7].Value.ToString();
                                    FRMM.Txt_Adresse.Text = DTG_SelectReinscription.Rows[i].Cells[8].Value.ToString();

                                    FRMM.P_Photo.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        com.Close();
                    }
                }
                FRMM.Show();
                FRMM.Btn_Valider.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    