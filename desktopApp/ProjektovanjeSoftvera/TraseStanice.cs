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
        
        private void buttonSacuvajStanicu_Click(object sender, EventArgs e)
        {
            AdminWebServis.Ekarta_AdminService admin = new AdminWebServis.Ekarta_AdminService();
            
            Stanice stanica = new Stanice();
            string imeStanice = this.textBoxImeStanice.Text;
            try
            {
                string kmOd = this.textBoxKmOd.Text;
                string kmDo = this.textBoxKmDo.Text;
                string a=imeStanice+"_"+kmOd+"_"+kmDo;
                admin.setStanica(a);
                MessageBox.Show("Neki tekst");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message); 
            }
            

           // int sa=1;

            //ovde treba da se pokupe podaci iz forme i uguraju u trasa objekat, pa onda
            //admin.setTrasa(trasa);
        }
    }
}
