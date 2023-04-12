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
    public partial class FRM_PageConnexion : Form
    {
        SqlConnection com = new SqlConnection("Data source=DESKTOP-2717K4D\\SQLEXPRESS; initial catalog=GestionKelasi; integrated security =true ");
        SqlDataAdapter singh = new SqlDataAdapter();
        SqlDataReader dr;
        public FRM_PageConnexion()
        {
            InitializeComponent();
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Connexion_Click(object sender, EventArgs e)
        {

        }

        private void FRM_PageConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
