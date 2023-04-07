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
    public partial class FRM_AjouterUtilisateur : Form
    {
        SqlConnection con = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataReader rd;
        public FRM_AjouterUtilisateur()
        {
            InitializeComponent();
            SetTabOrder();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_MotdePasse2_TextChanged(object sender, EventArgs e)
        {
            string password = Txt_MotdePasse.Text;

            // Vérification de la longueur du mot de passe
            if (password.Length < 7)
            {
                LbtErreur.Text = "Le mot de passe doit contenir au moins 7 caractères.";
                LbtErreur.Visible = true;
                errorProvider1.SetError(Txt_MotdePasse, "Le mot de passe doit contenir au moins 7 caractères.");
                return;
            }

            // Vérification de la présence de caractères spéciaux, de majuscules, de minuscules et de chiffres
            bool hasSpecialChar = false;
            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    hasSpecialChar = true;
                }
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                if (char.IsLower(c))
                {
                    hasLowercase = true;
                }
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }

            if (!hasSpecialChar || !hasUppercase || !hasLowercase || !hasDigit)
            {
                LbtErreur.Text = "Le mot de passe doit contenir au moins une lettre majuscule, une lettre minuscule, un chiffre et un caractère spécial.";
                LbtErreur.Visible = true;
                errorProvider1.SetError(Txt_MotdePasse, "Le mot de passe doit contenir au moins une lettre majuscule, une lettre minuscule, un chiffre et un caractère spécial.");
                return;
            }

            // Si toutes les conditions sont remplies, le label d'erreur est masqué
            LbtErreur.Visible = false;
            errorProvider1.Clear();
        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {

            // Vérifier si tous les champs sont remplis
            if (string.IsNullOrEmpty(Txt_NomPrenom.Text))
            {
                MessageBox.Show("Veuillez remplir le nom et prénom.");
                return;

            }
            else if (string.IsNullOrEmpty(Cmbb_Fonction.Text))
            {
                MessageBox.Show("Veuillez selectionné le champ fonction.");
                return;
            }
            else if (string.IsNullOrEmpty(Txt_Login.Text))
            {
                MessageBox.Show("Veuillez remplir le champ login.");
                return;
            }
            else if (string.IsNullOrEmpty(Txt_MotdePasse.Text))
            {
                MessageBox.Show("Veuillez remplir mot de passe.");
                return;
            }
            // Connexion à la base de données
            SqlConnection conn = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
            
            try
            {
                // Ouverture de la connexion
                conn.Open();

                // Vérification du directeur
                if (Cmbb_Fonction.Text == "Directeur")
                {
                    string queryDirecteur = "SELECT COUNT(*) FROM profil WHERE Fonction='Directeur'";

                    SqlCommand cmdDirecteur = new SqlCommand(queryDirecteur, conn);

                    int nbDirecteur = (int)cmdDirecteur.ExecuteScalar();

                    if (nbDirecteur > 0)
                    {
                        MessageBox.Show("Il ne peut y avoir qu'un seul directeur enregistré !");
                        return;
                    }
                }

                // Vérification du login existant
                string queryLogin = "SELECT COUNT(*) FROM profil WHERE login=@login";
                SqlCommand cmdLogin = new SqlCommand(queryLogin, conn);
                cmdLogin.Parameters.AddWithValue("@login", Txt_Login.Text);

                int nbLogin = (int)cmdLogin.ExecuteScalar();

                if (nbLogin > 0)
                {
                    MessageBox.Show("Ce login existe déjà. Veuillez en choisir un autre.");
                    return;
                }

                // Requête SQL pour l'insertion d'un profil
                string query = "INSERT INTO profil(NomEtPrenom, Fonction, login, password) VALUES (@nomEtPrenom, @fonction, @login, @password)";

                // Création d'un objet SqlCommand avec la requête SQL et la connexion
                SqlCommand cmd = new SqlCommand(query, conn);


                // Ajout des paramètres de la requête SQL
                cmd.Parameters.AddWithValue("@nomPrenom", Txt_NomPrenom.Text);
                cmd.Parameters.AddWithValue("@fonction", Cmbb_Fonction.Text);
                cmd.Parameters.AddWithValue("@login", Txt_Login.Text);
                cmd.Parameters.AddWithValue("@password", Txt_MotdePasse.Text);
                // Exécution de la requête SQL
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Enregistrement réussi !");
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'enregistrement...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                // Fermeture de la connexion
                conn.Close();
            }
        }

        private void SetTabOrder()
        {
            this.TabIndex = 0;

            // Définir l'ordre des focus pour chaque contrôle sur le formulaire
            Txt_NomPrenom.TabIndex = 1;
            Cmbb_Fonction.TabIndex = 2;
            Txt_Login.TabIndex = 3;
            Txt_MotdePasse.TabIndex = 4;
        }

        private void Clear()
        {
            // Remettre tous les champs de formulaire à leur valeur par défaut
            Txt_NomPrenom.Text = "";
            Cmbb_Fonction.SelectedIndex = -1;
            Txt_Login.Text = "";
            Txt_MotdePasse.Text = "";
        }
    }
}
