using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_KELASI.PL
{
    public partial class FRM_AjouterModifier_Reinscription : Form
    {
        SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataAdapter singh = new SqlDataAdapter();
        SqlDataReader dr;
        public FRM_AjouterModifier_Reinscription()
        {
            InitializeComponent();
            GenerateAutoID();
            //GetPrixInscription();
            CombClasse();
            timer1.Start();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            FRM_SelectReinscription FRMSR = new FRM_SelectReinscription();
            FRMSR.Show();
            Btn_Valider.Visible=false;
            Close();
        }

    
        private void GenerateAutoID()
        {
            try
            {
                string currentYear = DateTime.Now.Year.ToString();
                string query = "SELECT MAX(IDReincription) FROM reinscription WHERE IDReincription LIKE '%" + currentYear + "%'";
                SqlCommand cmd = new SqlCommand(query, com);
                com.Open();
                string maxID = cmd.ExecuteScalar().ToString();

                if (string.IsNullOrEmpty(maxID))
                {
                    TxtID_Reinscription.Text = currentYear + "-0001";
                }
                else
                {
                    int lastID = int.Parse(maxID.Substring(5));
                    TxtID_Reinscription.Text = currentYear + "-" + (lastID + 1).ToString("0000");
                }
                com.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetPrixInscription()
        {
            string sqlquery = "SELECT * FROM [dbo].[FraisReinscription] where CodeFraisRe=@CodeFraisRe";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, com);
            com.Open();
            sqlcomm.Parameters.AddWithValue("@CodeFraisRe", Cmb_Classe.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TxTID_FraisReinscrption.Text = dr["CodeFraisRe"].ToString();
                TxtFraisnscription.Text = dr["fraisReinscription"].ToString();
            }
            com.Close();
        }

        private void CombClasse()
        {
            string sqlquery = "SELECT * FROM [dbo].[classe]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, com);
            com.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Cmb_Classe.ValueMember = "codeclasse";
            Cmb_Classe.DisplayMember = "classe";
            Cmb_Classe.DataSource = dt;
            TxtFraisnscription.Enabled = false;

            com.Close();
        }


        BindingSource bsAnneAcademique = new BindingSource();
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

        private void FRM_AjouterModifier_Reinscription_Load(object sender, EventArgs e)
        {
            CombAnneeScolaire(); 
        }

        private void Cmb_Classe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPrixInscription();
        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            // Vérifier si l'ID de l'étudiant est vide
            if (string.IsNullOrEmpty(Txt_IDEtudiant.Text))
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
                return;
            }

            // Vérifier si la classe et l'année scolaire ont été sélectionnées
            if (Cmb_Classe.SelectedIndex == -1 || Cmb_AnneeScolaire.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner la classe et l'année scolaire.");
                return;
            }

            // Vérifier si le RadioButton a été sélectionné
            if (!RB_Ancien.Checked && !RB_Nouveau.Checked)
            {
                MessageBox.Show("Veuillez sélectionner un profil.");
                return;
            }

            // Vérifier si l'élève avec cet ID existe dans la base de données
            SqlConnection con = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM etudiant WHERE codeEt = @CodeEtudiant", con);
            cmd.Parameters.AddWithValue("@CodeEtudiant", Txt_IDEtudiant.Text);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count == 0)
            {
                MessageBox.Show("Aucun élève avec cet ID n'a été trouvé dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Demander confirmation avant la mise à jour
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir modifier l'inscription de cet étudiant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Effectuer la mise à jour dans la base de données
            con.Open();
            cmd = new SqlCommand("UPDATE reinscription SET CodeFraisRe = @CodeFraisRe, profil = @Profil WHERE codeEt = @CodeEt AND codeclasse = @CodeClasse AND codeAn = @CodeAn", con);
            cmd.Parameters.AddWithValue("@CodeFraisRe", TxTID_FraisReinscrption.Text);
            cmd.Parameters.AddWithValue("@Profil", Profil);
            cmd.Parameters.AddWithValue("@CodeEt", Txt_IDEtudiant.Text);
            cmd.Parameters.AddWithValue("@CodeClasse", Cmb_Classe.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@CodeAn", Cmb_AnneeScolaire.SelectedValue.ToString());
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("L'inscription a été modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de l'inscription.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {
            if (Cmb_Classe.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir de selectionnée le champs classe !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_Classe.Focus();
                return;
            }
            else if (Cmb_AnneeScolaire.Text == "")
            {
                MessageBox.Show("Vous avez oublié de remplir de sélectionnée champs l'année accadémique !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_AnneeScolaire.Focus();
                return;
            }
            else if(TxtFraisnscription.Text=="")
            {
                MessageBox.Show("Vous avez oublié le champs Frais de la réinscription !", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_AnneeScolaire.Focus();
                return;
            }
            else
            {
                // se connecter à la base de données
                SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
                //SqlDataAdapter singh = new SqlDataAdapter();
                //SqlDataReader dr;

                com.Open();

                // Récupérer les informations de l'élève et de la classe
                //string codeEtudiant = Txt_IDEtudiant.Text;
                string nomEtudiant = TxtNomEleve.Text;
                string prenomEtudiant = TxtPrenomEleve.Text;
                string codeClasse = Cmb_Classe.SelectedValue.ToString();
                string anneeAcademique = Cmb_AnneeScolaire.SelectedValue.ToString();

                // Vérifier si l'étudiant est déjà inscrit dans la classe et l'année académique
                string query = "SELECT * FROM reinscription r " +
                               "INNER JOIN etudiant e ON r.codeEt = e.codeEt " +
                               "WHERE e.NmEt = @NomEtudiant AND e.PrnmEt = @PrenomEtudiant " +
                               "AND r.codeclasse = @CodeClasse AND r.codeAn = @AnneeAcademique";

                SqlCommand cmd = new SqlCommand(query, com);
                cmd.Parameters.AddWithValue("@NomEtudiant", nomEtudiant);
                cmd.Parameters.AddWithValue("@PrenomEtudiant", prenomEtudiant);
                cmd.Parameters.AddWithValue("@CodeClasse", codeClasse);
                cmd.Parameters.AddWithValue("@AnneeAcademique", anneeAcademique);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Cet étudiant est déjà inscrit dans cette classe pour cette année académique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Close();
                    //com.Close();
                    return;
                }
                com.Close();
                reader.Close();


                com.Open();
                // Vérifier si le RadioButton a été sélectionné
                if (!RB_Ancien.Checked && !RB_Nouveau.Checked)
                {
                    MessageBox.Show("Veuillez sélectionner un profil.");
                    return;
                }

                // Insert data into inscrire table
                singh.InsertCommand = new SqlCommand("INSERT INTO reinscription (IDReincription, dtreinscription, CodeFraisRe, codeEt, codeclasse, codeAn, profil) VALUES (@IDReincription, @dtreinscription, @CodeFraisRe, @CodeEt, @codeclasse, @codeAn, @profil)", com);
                singh.InsertCommand.Parameters.AddWithValue("@IDReincription", Txt_IDEtudiant.Text);
                singh.InsertCommand.Parameters.AddWithValue("@dtreinscription", Lbl_Time.Text);
                singh.InsertCommand.Parameters.AddWithValue("@CodeFraisRe", TxTID_FraisReinscrption.Text);
                singh.InsertCommand.Parameters.AddWithValue("@CodeEt", Txt_IDEtudiant.Text);
                singh.InsertCommand.Parameters.AddWithValue("@codeclasse", Convert.ToString(Cmb_Classe.SelectedValue));
                singh.InsertCommand.Parameters.AddWithValue("@codeAn", Convert.ToInt32(Cmb_AnneeScolaire.SelectedValue));
                singh.InsertCommand.Parameters.AddWithValue("@profil", Profil);
                singh.InsertCommand.ExecuteNonQuery();
                singh.InsertCommand.Parameters.Clear();

                int rowsAffected = cmd.ExecuteNonQuery();
                com.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("L'inscription a été ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    com.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'inscription.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    com.Open();
                }
            }
        }

        string Profil;
        private void RB_Ancien_CheckedChanged(object sender, EventArgs e)
        {
            Profil = "Ancien";
        }

        private void RB_Nouveau_CheckedChanged(object sender, EventArgs e)
        {
            Profil = "Nouveau";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Lbl_Time.Text = dateTime.ToString();
        }
    }
}
