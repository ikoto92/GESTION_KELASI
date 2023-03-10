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
    public partial class USER_Page_Accueil : UserControl
    {

        private static USER_Page_Accueil UserPageAccueil;

        public static USER_Page_Accueil Instance
        {
            get
            {
                if (UserPageAccueil == null)
                {
                    UserPageAccueil = new USER_Page_Accueil();
                }
                return UserPageAccueil;
            }
        }
        public USER_Page_Accueil()
        {
            InitializeComponent();
        }
    }
}
