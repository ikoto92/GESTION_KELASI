using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTION_KELASI.PL
{
    public partial class FRM_ModiferUtilisateur : Form
    {
        public FRM_ModiferUtilisateur()
        {
            InitializeComponent();
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {
            // Vérification que tous les champs sont remplis
            // Vérification que tous les champs sont remplis
            if (string.IsNullOrEmpty(Txt_AncienMotdePasse.Text))
            {
                MessageBox.Show("Veuillez remplir le champ ancien mot de passe");
                return;
            }
            else if (string.IsNullOrEmpty(Txt_NouveauMotdePasse.Text))
            {
                MessageBox.Show("Veuillez remplir le champ nouveau mot de passe");
                return;
            }
            else if (string.IsNullOrEmpty(Txt_RepeteNouveauMotdePasse.Text))
            {
                MessageBox.Show("Veuillez remplir le champ répéter le nouveau mot de passe");
                return;
            }

            if (Txt_NouveauMotdePasse.Text != Txt_RepeteNouveauMotdePasse.Text)
            {
                MessageBox.Show("Les deux champs du nouveau mot de passe doivent correspondre");
                return;
            }

            int codeprofil = 1; // Remplacer 1 par le code du profil à modifier

            // Vérification de l'existence de l'utilisateur et de la validité de l'ancien mot de passe
            int count = 0;

            SqlConnection conn = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security = true ");

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM profil WHERE codeprofil=@codeprofil AND password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codeprofil", codeprofil);
                cmd.Parameters.AddWithValue("@password", Txt_AncienMotdePasse.Text);
                count = (int)cmd.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("Le mot de passe actuel est incorrect.");
                    return;
                }

                // Mise à jour du mot de passe
                query = "UPDATE profil SET password=@password WHERE codeprofil=@codeprofil";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@password", Txt_NouveauMotdePasse.Text);
                cmd.Parameters.AddWithValue("@codeprofil", codeprofil);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Le mot de passe a été mis à jour.");
                }
                else
                {
                    MessageBox.Show("Aucun mot de passe n'a été mis à jour.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la mise à jour du mot de passe : " + ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}


