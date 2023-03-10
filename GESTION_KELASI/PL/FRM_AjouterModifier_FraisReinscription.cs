using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_KELASI.PL
{
    public partial class FRM_AjouterModifier_FraisReinscription : Form
    {
        SqlConnection con = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataReader rd;
        public FRM_AjouterModifier_FraisReinscription()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_FraisInscription_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            string rqt = "SELECT * FROM FraisReinscription where fraisReinscription ='" + Txt_FraisReinscription.Text + "'";
            SqlCommand cmd = new SqlCommand(rqt, con);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                MessageBox.Show("Existe déjà dans la base données");
            }

            con.Close();
        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            con.Open();

            string rq = "insert into FraisReinscription (fraisReinscription) VALUES('" + Txt_FraisReinscription.Text + "')";
            SqlCommand cmd = new SqlCommand(rq, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("La nouvelle année à été crée avec succée");

            con.Close();
        }
    }
}
