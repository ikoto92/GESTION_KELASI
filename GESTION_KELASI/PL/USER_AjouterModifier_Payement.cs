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
    public partial class USER_AjouterModifier_Payement : UserControl
    {
        private static USER_AjouterModifier_Payement UserPayement;

        public static USER_AjouterModifier_Payement Instance
        {
            get
            {
                if (UserPayement == null)
                {
                    UserPayement = new USER_AjouterModifier_Payement();
                }
                return UserPayement;
            }
        }
        public USER_AjouterModifier_Payement()
        {
            InitializeComponent();
        }

        private void Btn_Payement_Click(object sender, EventArgs e)
        {
            FRM_Payement_FraisScolaire AMR = new FRM_Payement_FraisScolaire();
            AMR.Show();
        }
    }
}
