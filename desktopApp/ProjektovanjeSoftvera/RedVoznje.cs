using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;


namespace ProjektovanjeSoftvera
{
    public partial class RedVoznje : Form
    {
        public RedVoznje()
        {
            InitializeComponent();
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
            Dictionary<int, string> dani = new Dictionary<int, string>();
            dani.Add(0, "Izaberi...");
            dani.Add(1, "Radni dani");
            dani.Add(2, "Subota");
            dani.Add(3, "Nedelja");
            this.comboBoxDan.DataSource = new BindingSource(dani, null);
            this.comboBoxDan.DisplayMember = "Value";
            this.comboBoxDan.ValueMember = "Key";

            this.popuniRedVoznje();
            this.popuniTrase(this.comboBoxTrasa);
            this.popuniTrase(this.comboBoxTrasaOtkazi);
            this.popuniOtkazaneVoznje();
        }

        #region Dodaj voznju

        private void buttonDodajvoznju_Click(object sender, EventArgs e)
        {
            if (this.comboBoxTrasa.SelectedIndex != 0 && this.comboBoxDan.SelectedIndex != 0 && this.textBoxSat.Text != "" && this.textBoxMinut.Text != "")
            {
                if (Int32.Parse(this.textBoxSat.Text) >= 0 && Int32.Parse(this.textBoxSat.Text) < 24 && Int32.Parse(this.textBoxMinut.Text) >= 0 && Int32.Parse(this.textBoxMinut.Text) < 60)
                {
                    AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                    int idTrasa = Int32.Parse(this.comboBoxTrasa.SelectedValue.ToString());
                    int dan = Int32.Parse(this.comboBoxDan.SelectedValue.ToString());
                    string sat = this.textBoxSat.Text;
                    string minut = this.textBoxMinut.Text;
                    string zaSlanje = idTrasa + "_" + dan + "_" + sat + "_" + minut;
                    if (Int32.Parse(this.comboBoxTrasaIzmeni.SelectedValue.ToString()) != 0)
                    {
                        zaSlanje += "_" + this.comboBoxTrasaIzmeni.SelectedValue.ToString();
                    }
                    try{veza.setRedVoznje(zaSlanje);}
                    catch (Exception ex){}
                    this.popuniRedVoznje();
                }
                else
                {
                    MessageBox.Show("Sat i minut moraju da budu u odgovarajucem opssegu!.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                }
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void comboBoxTrasaIzmeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxTrasaIzmeni.SelectedIndex == 0)
            {
                this.comboBoxTrasa.SelectedValue = 0;
                this.comboBoxDan.SelectedValue = 0;
                this.textBoxSat.Text = "";
                this.textBoxMinut.Text = "";
            }
            else
            {
                int selectedId = Int32.Parse(this.comboBoxTrasaIzmeni.SelectedValue.ToString());
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                string result=veza.getJedanRedVoznje(selectedId);
                string[] array = result.Split('_');
                this.comboBoxTrasa.SelectedValue = Int32.Parse(array[1]);
                this.comboBoxDan.SelectedValue = Int32.Parse(array[2]);
                this.textBoxSat.Text = array[3].Split(':')[0];
                this.textBoxMinut.Text = array[3].Split(':')[1];
            }
        }

        private void buttonIzbrisiRedVoznje_Click(object sender, EventArgs e)
        {
            if (this.comboBoxTrasaIzmeni.SelectedIndex != 0)
            {
                int idRedVoznje = Int32.Parse(this.comboBoxTrasaIzmeni.SelectedValue.ToString());
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                try { veza.unsetRedVoznje(idRedVoznje); }
                catch(Exception ex){}
                this.comboBoxTrasa.SelectedValue = 0;
                this.comboBoxDan.SelectedValue = 0;
                this.textBoxSat.Text = "";
                this.textBoxMinut.Text = "";

                string result = veza.getRedVoznje();
                string[] array = result.Split('#');
                int count = array.Count();
                Dictionary<int, string> redoviVoznje = new Dictionary<int, string>();
                redoviVoznje.Add(0, "Izaberi...");
                string[] niz = new string[100];
                for (int i = 0; i < count - 1; i++)
                {
                    string[] elements = array[i].Split('_');
                    redoviVoznje.Add(Convert.ToInt32(elements[0]), elements[4] + " " + elements[3]);
                }
                this.comboBoxTrasaIzmeni.DataSource = new BindingSource(redoviVoznje, null);
                this.comboBoxTrasaIzmeni.DisplayMember = "Value";
                this.comboBoxTrasaIzmeni.ValueMember = "Key";
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
            if (this.comboBoxOtkazaneVoznje.SelectedIndex != 0)
            {
                zaSlanje += "_" + this.comboBoxOtkazaneVoznje.SelectedValue.ToString();
            }
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
            try { veza.setOtkazanaVoznja(zaSlanje); }
            catch (Exception ex) { }
            this.ocistiOtkazaneVoznje();
            this.popuniOtkazaneVoznje();

        }

        private void buttonIzbrisiOtkazanaVoznja_Click(object sender, EventArgs e)
        {
            if (this.comboBoxOtkazaneVoznje.SelectedIndex != 0)
            {
                int idOtkazanaVoznja = Int32.Parse(this.comboBoxOtkazaneVoznje.SelectedValue.ToString());
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                try { veza.unsetOtkazanaVoznja(idOtkazanaVoznja); }
                catch (Exception ex) { }
                this.popuniOtkazaneVoznje();
                this.popuniRedVoznje();
                this.ocistiOtkazaneVoznje();
            }
            else
            {
                MessageBox.Show("Izaberite otkazanu voznju!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxOtkazaneVoznje_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.comboBoxOtkazaneVoznje.SelectedIndex == 0)
            {
                this.comboBoxTrasaOtkazi.SelectedIndex = 0;
                this.dateTimePickerDatum.Value = DateTime.Now;
                this.textBoxMinutOtkazi.Text = "";
                this.textBoxSatOtkazi.Text = "";
            }
            else
            {
                int id=Int32.Parse(this.comboBoxOtkazaneVoznje.SelectedValue.ToString());
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                string result = veza.getOtkazanaVoznja(id);
                string[] array = result.Split('_');
                this.comboBoxTrasaOtkazi.SelectedValue = Int32.Parse(array[0]);
                dateTimePickerDatum.Value = new DateTime(Int32.Parse(array[3]), Int32.Parse(array[2]), Int32.Parse(array[1]));
                this.textBoxSatOtkazi.Text = array[4].Split(':')[0];
                this.textBoxMinutOtkazi.Text = array[4].Split(':')[1];
            }
        }

        #endregion


        #region Dodatni kod

        private void popuniTrase(ComboBox cb)
        {
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
            string result = veza.getTrase();
            string[] array = result.Split('#');
            int count = array.Count();
            Dictionary<int, string> trase = new Dictionary<int, string>();
            trase.Add(0, "Izaberi...");
            for (int i = 0; i < count - 1; i++)
            {
                string[] elements = array[i].Split('_');
                trase.Add(Convert.ToInt32(elements[0]), elements[1] + " - " + elements[2]);
            }
            cb.DataSource = new BindingSource(trase, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }
        private void popuniRedVoznje()
        {
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
            string result = veza.getRedVoznje();
            string[] array = result.Split('#');
            int count = array.Count();
            Dictionary<int, string> redoviVoznje = new Dictionary<int, string>();
            redoviVoznje.Add(0, "Izaberi...");
            string[] niz = new string[100];
            for (int i = 0; i < count - 1; i++)
            {
                string[] elements = array[i].Split('_');
                redoviVoznje.Add(Convert.ToInt32(elements[0]), elements[4] + " " + elements[3]);
            }
            this.comboBoxTrasaIzmeni.DataSource = new BindingSource(redoviVoznje, null);
            this.comboBoxTrasaIzmeni.DisplayMember = "Value";
            this.comboBoxTrasaIzmeni.ValueMember = "Key";
        }
        private void popuniOtkazaneVoznje()
        {
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
            string result = veza.getOtkazaneVoznje();
            string[] array = result.Split('#');
            int count = array.Count();
            Dictionary<int, string> redoviVoznje = new Dictionary<int, string>();
            redoviVoznje.Add(0, "Izaberi...");
            for (int i = 0; i < count - 1; i++)
            {
                string[] elements = array[i].Split('_');
                redoviVoznje.Add(Convert.ToInt32(elements[0]), elements[1] + " " + elements[2]);
            }
            this.comboBoxOtkazaneVoznje.DataSource = new BindingSource(redoviVoznje, null);
            this.comboBoxOtkazaneVoznje.DisplayMember = "Value";
            this.comboBoxOtkazaneVoznje.ValueMember = "Key";
        }

        private void ocistiOtkazaneVoznje()
        {
            this.comboBoxOtkazaneVoznje.SelectedIndex = 0;
            this.comboBoxTrasaOtkazi.SelectedIndex =0;
            this.dateTimePickerDatum.Value = DateTime.Now;
            this.textBoxSatOtkazi.Text = "";
            this.textBoxMinutOtkazi.Text = "";
        }

        #endregion

    }
}
