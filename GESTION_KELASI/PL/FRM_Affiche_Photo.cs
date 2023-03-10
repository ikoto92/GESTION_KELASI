using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_KELASI.PL
{
    public partial class FRM_Affiche_Photo : Form
    {
        public FRM_Affiche_Photo()
        {
            InitializeComponent();
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
