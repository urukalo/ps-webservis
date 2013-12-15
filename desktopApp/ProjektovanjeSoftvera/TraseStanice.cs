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

        #region Stanice

        private void buttonSacuvajStanicu_Click(object sender, EventArgs e)
        {
            AdminWebServis.Ekarta_AdminService admin = new AdminWebServis.Ekarta_AdminService();
            
            Stanice stanica = new Stanice();
            string imeStanice = this.textBoxImeStanice.Text;
            try
            {
                int kmOd = Int32.Parse(this.textBoxKmOd.Text);
                int kmDo = Int32.Parse(this.textBoxKmDo.Text);
                int idTrasa = Int32.Parse(this.comboBoxTrase.SelectedValue.ToString());
                string zaSlanje=imeStanice+"_"+kmOd+"_"+kmDo+"_"+idTrasa;
                //povezati se sa servisom i posladiti
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void buttonIzbrisiStanicu_Click(object sender, EventArgs e)
        {
            if (this.comboBoxStanice.SelectedIndex > 0)
            {
                int idStanice = Int32.Parse(this.comboBoxStanice.SelectedValue.ToString());
                //povezati se sa servisom i proslediti idStanice
            }
            else
            {
                MessageBox.Show("Izaberite stanicu prvo","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); 
            }
        }

        private void comboBoxStanice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxStanice.SelectedIndex == 0)
            {
                this.textBoxImeStanice.Text = "";
                this.textBoxKmOd.Text = "";
                this.textBoxKmDo.Text = "";
                this.comboBoxIzaberiTrasu.SelectedIndex = 0;
            }
            else
            {
               //povezati se sa servisom, dohvatiti rezultat i upisatui u polja
            }
        }

        #endregion

        #region Trase

        private void buttonSacuvajTrasu_Click(object sender, EventArgs e)
        {
            string pocetna = this.comboBoxPocetnaStanica.SelectedText;
            string krajnja = this.comboBoxKrajnjaStanica.SelectedText;
            string ukupnoKm = this.textBoxUkupnoKm.Text;
            string zaSlanje = pocetna + "_" + krajnja + "_" + ukupnoKm;
            if (this.comboBoxIzaberiTrasu.SelectedIndex > 0)
            {
                int idTrasa = Int32.Parse(this.comboBoxIzaberiTrasu.SelectedIndex.ToString());
                zaSlanje += "_" + idTrasa;
            }
            //veza sa servisom i slanje stringa "zaSlanje" u funkciju
        }

        private void buttonIzbrisiTrasu_Click(object sender, EventArgs e)
        {
            if (this.comboBoxIzaberiTrasu.SelectedIndex > 0)
            {
                int idStanice = Int32.Parse(this.comboBoxIzaberiTrasu.SelectedValue.ToString());
                //povezati se sa servisom i proslediti funkciji na servisu id koji se brise
            }
            else
            {
                MessageBox.Show("Izaberite trasu prvo", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxIzaberiTrasu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxIzaberiTrasu.SelectedIndex == 0)
            {
                this.comboBoxPocetnaStanica.SelectedIndex = 0;
                this.comboBoxKrajnjaStanica.SelectedIndex = 0;
                this.textBoxUkupnoKm.Text = "";
            }
            else
            {
                //povezati se sa servisom, dohvatiti podatke i upisati u polja
            }
        }

        #endregion

    }
}
