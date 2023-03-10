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
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_MotdePasse2_TextChanged(object sender, EventArgs e)
        {
            if (Txt_MotdePasse.Text == Txt_MotdePasse2.Text)
            {
                if (Txt_MotdePasse.Text.Length > 6)
                {
                    LbtErreur.Visible = false;
                }
                else
                {
                    errorProvider1.SetError(Txt_MotdePasse, "le mot de passe doit contenir au moins 7 caractères...!! ");
                }

            }
            else
            {
                LbtErreur.Text = "Vérifier votre mot de passe";
                LbtErreur.Visible = true;
            }
        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {
            con.Open();
            
            string rq = "insert into profil (NomEtPrenom, Fonction, login, password) VALUES('"+ Txt_NomPrenom.Text + "', '"+ Cmbb_Fonction.Text + "', '"+ Txt_Login.Text + "', '"+ Txt_MotdePasse.Text + "')";
            SqlCommand cmd = new SqlCommand(rq, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Votre compté à été crée avec succée");

            con.Close();
        }

        private void Txt_Login_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            string rqt = "SELECT * FROM profil where login ='" + Txt_Login.Text + "'";
            SqlCommand cmd = new SqlCommand(rqt, con);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                MessageBox.Show("Existe déjà dans la base données");
            }

            con.Close();
        }
    }
}
