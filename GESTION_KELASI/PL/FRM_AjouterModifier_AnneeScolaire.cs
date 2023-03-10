using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GESTION_KELASI.PL
{
    public partial class FRM_AjouterModifier_AnneeScolaire : Form
    {

        SqlConnection con = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataAdapter singh = new SqlDataAdapter();
        SqlDataReader dr;
        
        public FRM_AjouterModifier_AnneeScolaire()
        {
            InitializeComponent();
        }

        private void Btn_CloseA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ClearParent()
        {
            TxtAnneeScolaire.Text = "";
 
        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            con.Open();

            string rq = "insert into anneAcademique (anne) VALUES('" + TxtAnneeScolaire.Text + "')";
            SqlCommand cmd = new SqlCommand(rq, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("La nouvelle année à été crée avec succée");

            con.Close();
        }

        private void TxtAnneeScolaire_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            string rqt = "SELECT * FROM anneAcademique where anne ='" + TxtAnneeScolaire.Text + "'";
            SqlCommand cmd = new SqlCommand(rqt, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                MessageBox.Show("Existe déjà dans la base données");
            }

            con.Close();
        }

        public string SelectVerif()
        {
            int NombreligneSelect = 0;
            for (int i = 0; i < DGV_Annee.Rows.Count; i++)
            {
                if ((bool)DGV_Annee.Rows[i].Cells[0].Value == true)
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

        public string IDselect;
        private void Btn_Afficher_Click(object sender, EventArgs e)
        {
            singh.SelectCommand = new SqlCommand("SELECT * FROM anneAcademique", con);
            con.Open();
            try
            {
                singh.SelectCommand.ExecuteNonQuery();
                dr = singh.SelectCommand.ExecuteReader();
                DGV_Annee.Rows.Clear();

                while (dr.Read())
                {
                    DGV_Annee.Rows.Add(false, dr.GetValue(0), dr.GetValue(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
            con.Close();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            if (SelectVerif() == null)
            {
                for (int i = 0; i < DGV_Annee.Rows.Count; i++)
                {
                    if ((bool)DGV_Annee.Rows[i].Cells[0].Value == true)//si chekbox est vrai afficher les information dans le formulaire
                    {
                        //IDselect = (string)DtgClasse.Rows[i].Cells[1].Value;
                        TxtAnneeScolaire.Text = DGV_Annee.Rows[i].Cells[2].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}