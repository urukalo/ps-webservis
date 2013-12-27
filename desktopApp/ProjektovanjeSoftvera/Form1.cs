using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjektovanjeSoftvera.EkartaService;
using ProjektovanjeSoftvera.AdminService;
using System.Runtime.Serialization.Json;
using System.IO;

namespace ProjektovanjeSoftvera
{
    public partial class Form1 : Form
    {

        Ekarta_ServisPortClient servis = new Ekarta_ServisPortClient();
       

        public Form1()
        {
            InitializeComponent();
            this.dateTimePickerDatumPutovanja.MinDate = DateTime.Now;
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
            this.comboBoxTrasa.DataSource = new BindingSource(trase, null);
            this.comboBoxTrasa.DisplayMember = "Value";
            this.comboBoxTrasa.ValueMember = "Key";
        }

        private void checkBoxPopust_CheckedChanged(object sender, EventArgs e)
        {
            popuniPopuste();
            if(this.checkBoxPopust.Checked)
                comboBoxVrstaPopust.Visible = true;
            else
                comboBoxVrstaPopust.Visible = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginDijalog loginDijalog = new LoginDijalog();
            loginDijalog.ShowDialog();
        }

        private void traseIStaniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraseStanice tis = new TraseStanice();
            tis.ShowDialog();
        }

        private void redVoznjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedVoznje redVoznje = new RedVoznje();
            redVoznje.ShowDialog();
        }

        private void administracijaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxTrasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxTrasa.SelectedIndex != 0)
            {
                int idTrasa = Int32.Parse(this.comboBoxTrasa.SelectedValue.ToString());
                popuniStanice(this.comboBoxPolaznaStanica, idTrasa);
                this.comboBoxPolaznaStanica.Enabled = true;
            }
        }

        private void comboBoxPolaznaStanica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxPolaznaStanica.SelectedIndex != 0)
            {
                int idTrasa = Int32.Parse(this.comboBoxTrasa.SelectedValue.ToString());
                int idStanica = Int32.Parse(this.comboBoxPolaznaStanica.SelectedValue.ToString());
                popuniStanice(this.comboBoxDolaznaStanica, idTrasa,idStanica);
                this.comboBoxDolaznaStanica.Enabled = true;
            }
        }

        private void dateTimePickerDatumPutovanja_ValueChanged(object sender, EventArgs e)
        {
            if (this.comboBoxTrasa.SelectedIndex > 0)
            {
                this.comboBoxVremePolaska.Enabled = true;
                this.checkBoxPopust.Enabled = true;
                string datum = this.dateTimePickerDatumPutovanja.Value.Day + "_" + this.dateTimePickerDatumPutovanja.Value.Month + "_" + this.dateTimePickerDatumPutovanja.Value.Year;
                string zaSlanje = this.comboBoxTrasa.SelectedValue.ToString() + "_" + datum;
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                string result = veza.getVremeZaDatum(zaSlanje);

                string[] array = result.Split('#');
                int count = array.Count();
                Dictionary<int, string> trase = new Dictionary<int, string>();
                trase.Add(0, "Izaberi...");
                for (int i = 0; i < count - 1; i++)
                {
                    string[] elements = array[i].Split('_');
                    trase.Add(Convert.ToInt32(elements[1]), elements[0]);
                }
                this.comboBoxVremePolaska.DataSource = new BindingSource(trase, null);
                this.comboBoxVremePolaska.DisplayMember = "Value";
                this.comboBoxVremePolaska.ValueMember = "Key";
            }
        }

        private void comboBoxDolaznaStanica_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dateTimePickerDatumPutovanja.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ponistiSve();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idTrasa = this.comboBoxTrasa.SelectedValue.ToString();
            string idPopust = this.comboBoxVrstaPopust.SelectedValue.ToString();
            string idStanicaPolaska = this.comboBoxPolaznaStanica.SelectedValue.ToString();
            string idStanicaDolaska = this.comboBoxDolaznaStanica.SelectedValue.ToString();
            string vreme = comboBoxVremePolaska.Text;
            string vremePolaska = dateTimePickerDatumPutovanja.Value.Day + "-" + dateTimePickerDatumPutovanja.Value.Month + "-" + dateTimePickerDatumPutovanja.Value.Year + "-" + vreme.Split(':')[0] + "-" + vreme.Split(':')[1];
            string povratna = this.checkBoxPovratna.Checked ? "1" : "0";
            string cena = "300";
            string zaSlanje = idTrasa + "_" + idPopust + "_" + idStanicaPolaska + "_" + idStanicaDolaska + "_" + vremePolaska + "_" + povratna + "_" + cena;
            Ekarta_AdminPortClient veza = new Ekarta_AdminPortClient();
            try { veza.setKarta(zaSlanje); }
            catch (Exception ex) { }
            ponistiSve();
            MessageBox.Show("Karta rezervisana","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        
        }

        #region Dodatne funkcije

        private void popuniStanice(ComboBox cb, int idTrasa, int idStanica = 0)
        {
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
            string result = "";
            if (idStanica == 0)
            {
                result = veza.getStaniceZaTrasu(idTrasa);
            }
            else
            {
                result = veza.getStaniceZaTrasuPosle(idTrasa, idStanica);
            }
            string[] array = result.Split('#');
            int count = array.Count();
            Dictionary<int, string> trase = new Dictionary<int, string>();
            trase.Add(0, "Izaberi...");
            for (int i = 0; i < count - 1; i++)
            {
                string[] elements = array[i].Split('_');
                trase.Add(Convert.ToInt32(elements[1]), elements[0]);
            }
            cb.DataSource = new BindingSource(trase, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }
        private void popuniPopuste()
        {
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
            string result = veza.getPopust(0);
            string[] array = result.Split('#');
            int count = array.Count();
            Dictionary<int, string> trase = new Dictionary<int, string>();
            trase.Add(0, "Izaberi...");
            for (int i = 0; i < count - 1; i++)
            {
                string[] elements = array[i].Split('_');
                trase.Add(Convert.ToInt32(elements[0]), elements[1]);
            }
            this.comboBoxVrstaPopust.DataSource = new BindingSource(trase, null);
            this.comboBoxVrstaPopust.DisplayMember = "Value";
            this.comboBoxVrstaPopust.ValueMember = "Key";
        }
        private void ponistiSve()
        {
            comboBoxTrasa.SelectedIndex = 0;
            comboBoxPolaznaStanica.SelectedIndex = 0;
            comboBoxPolaznaStanica.Enabled = false;
            comboBoxDolaznaStanica.SelectedIndex = 0;
            comboBoxDolaznaStanica.Enabled = false;
            comboBoxVrstaPopust.SelectedIndex = 0;
            comboBoxVrstaPopust.Visible = false;
            comboBoxVremePolaska.SelectedIndex = 0;
            comboBoxVremePolaska.Enabled = false;

            dateTimePickerDatumPutovanja.Enabled = false;
            checkBoxPopust.Checked = false;
            checkBoxPovratna.Checked = false;
        }

        #endregion



    }
}
