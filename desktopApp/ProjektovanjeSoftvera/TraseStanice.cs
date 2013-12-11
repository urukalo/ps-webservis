using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjektovanjeSoftvera
{
    public partial class TraseStanice : Form
    {
        public TraseStanice()
        {
            InitializeComponent();
        }

        private void buttonDodajTrasu_Click(object sender, EventArgs e)
        {
            ProjektovanjeSoftvera.AdminWebServis.Ekarta_AdminService admin = new AdminWebServis.Ekarta_AdminService();
            AdminWebServis.Application_Model_Trasa trasa = new AdminWebServis.Application_Model_Trasa();
            //ovde treba da se pokupe podaci iz forme i uguraju u trasa objekat, pa onda
            admin.setTrasa(trasa);
        }
    }
}
