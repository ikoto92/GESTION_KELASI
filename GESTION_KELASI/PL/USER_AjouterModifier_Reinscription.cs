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
    }
}
