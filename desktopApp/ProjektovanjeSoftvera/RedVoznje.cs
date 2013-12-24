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
    public partial class RedVoznje : Form
    {
        public RedVoznje()
        {
            InitializeComponent();
           
        }

        #region Dodaj voznju

        private void buttonDodajvoznju_Click(object sender, EventArgs e)
        {
            if (this.comboBoxTrasa.SelectedIndex != 0 && this.comboBoxDan.SelectedIndex != 0 && this.textBoxSat.Text != "" && this.textBoxMinut.Text != "")
            {
                int idTrasa = Int32.Parse(this.comboBoxTrasa.SelectedIndex.ToString());
                int dan = Int32.Parse(this.comboBoxDan.SelectedIndex.ToString());
                string sat = this.textBoxSat.Text;
                string minut = this.textBoxMinut.Text;
                string zaSlanje = idTrasa + "_" + dan + "_" + sat + "_" +minut;
                if (this.comboBoxTrasaIzmeni.SelectedIndex != 0)
                {
                    zaSlanje += "_" + this.comboBoxTrasaIzmeni.SelectedValue.ToString();
                }
                //veza sa servisom i slanje stringa
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void comboBoxTrasaIzmeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxTrasaIzmeni.SelectedText == "Izaberite...")
            {
                this.comboBoxTrasa.SelectedIndex = 0;
                this.comboBoxDan.SelectedIndex = 0;
                this.textBoxSat.Text = "";
                this.textBoxMinut.Text = "";
            }
            else
            {

                //veza sa servisom i podesavanje polja
            }
        }

        private void buttonIzbrisiRedVoznje_Click(object sender, EventArgs e)
        {
            if (this.comboBoxTrasaIzmeni.SelectedIndex != 0)
            {
                int idRedVoznje = Int32.Parse(this.comboBoxTrasaIzmeni.SelectedValue.ToString());
                //veza sa servisom i prosledivanja idRedVoznje
            }
            else
	        {
                MessageBox.Show("Izaberite red voznje!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
	        }
        }

        #endregion

        #region Otkazi voznju

        private void buttonSacuvajOtkazaneVoznje_Click(object sender, EventArgs e)
        {
            string idTrasa = this.comboBoxTrasaOtkazi.SelectedValue.ToString();
            string dan = this.dateTimePickerDatum.Value.Day.ToString();
            string mesec = this.dateTimePickerDatum.Value.Month.ToString();
            string godina = this.dateTimePickerDatum.Value.Year.ToString();
            string sat = this.textBoxSatOtkazi.Text;
            string minut = this.textBoxMinutOtkazi.Text;
            string zaSlanje = idTrasa + "_" + dan + "_" + mesec + "_" + godina + "_" + sat + "_" + minut;
            //poslati string preko servisa
        }

        private void buttonIzbrisiOtkazanaVoznja_Click(object sender, EventArgs e)
        {
            if (this.comboBoxOtkazaneVoznje.SelectedIndex != 0)
            {
                string idOtkazanaVoznja = this.comboBoxOtkazaneVoznje.SelectedValue.ToString();
                //poslati idOtkazanaVoznja servisom da se obrise iz baze
            }
            else
            {
                MessageBox.Show("Izaberite otkazanu voznju!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxOtkazaneVoznje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxOtkazaneVoznje.SelectedIndex != 0)
            {
                //povezatis e sa servisom i popuniti polja
            }
            else
            {
                this.comboBoxTrasaOtkazi.SelectedIndex = 0;
                this.dateTimePickerDatum.Value = DateTime.Now;
                this.textBoxMinutOtkazi.Text = "";
                this.textBoxSatOtkazi.Text = "";
            }
        }

        #endregion

    }
}
