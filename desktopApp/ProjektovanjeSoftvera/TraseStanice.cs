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
            this.popuniStanice();
            this.popuniTrase(this.comboBoxTrase);
            this.popuniTrase(this.comboBoxIzaberiTrasu);
            this.sveStanice(this.comboBoxPocetnaStanica);
            this.sveStanice(this.comboBoxKrajnjaStanica);
        }

        #region Stanice

        private void buttonSacuvajStanicu_Click(object sender, EventArgs e)
        {
            if (this.textBoxImeStanice.Text != "" && this.comboBoxTrase.SelectedIndex != 0 && this.textBoxKmOd.Text != "" && this.textBoxKmDo.Text != "")
            {

                string imeStanice = this.textBoxImeStanice.Text;
                string zaSlanje = "";
                try
                {
                    int kmOd = Int32.Parse(this.textBoxKmOd.Text);
                    int kmDo = Int32.Parse(this.textBoxKmDo.Text);
                    int idTrasa = Int32.Parse(this.comboBoxTrase.SelectedValue.ToString());
                    zaSlanje = imeStanice + "_" + idTrasa + "_" + kmOd + "_" + kmDo;
                    if (this.textBoxIdStanice.Text == ""){zaSlanje += "_0";}
                    else{zaSlanje += "_" + this.textBoxIdStanice.Text;}
                    if (this.comboBoxStanice.SelectedIndex != 0){zaSlanje += "_" + this.comboBoxStanice.SelectedValue.ToString();}
                }
                catch (FormatException ex){MessageBox.Show(ex.Message, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
                
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                try { veza.setTrasaStanica(zaSlanje); }
                catch (Exception ex) { }

                this.textBoxIdStanice.Text = "";
                this.textBoxImeStanice.Text = "";
                this.textBoxKmDo.Text = "";
                this.textBoxKmOd.Text = "";
                this.comboBoxTrase.SelectedIndex = 0;
                this.comboBoxStanice.SelectedIndex = 0;
                this.popuniStanice();
                this.popuniTrase(this.comboBoxTrase);
                this.sveStanice(this.comboBoxPocetnaStanica);
                this.sveStanice(this.comboBoxKrajnjaStanica);
            }
            else if (this.textBoxImeStanice.Text != "")
            {
                string zaSlanje = this.textBoxImeStanice.Text;
                if (this.textBoxIdStanice.Text != "")
                {
                    zaSlanje += "_"+this.textBoxIdStanice.Text;
                }
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                try { veza.setStanica(zaSlanje); }
                catch (Exception ex) { }
                this.textBoxIdStanice.Text = "";
                this.textBoxImeStanice.Text = "";
                this.textBoxKmDo.Text = "";
                this.textBoxKmOd.Text = "";
                this.comboBoxTrase.SelectedIndex = 0;
                this.comboBoxStanice.SelectedIndex = 0;
                this.popuniStanice();
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonIzbrisiStanicu_Click(object sender, EventArgs e)
        {
            if (this.comboBoxStanice.SelectedIndex > 0)
            {

                int idTrasaStanica = Int32.Parse(this.comboBoxStanice.SelectedValue.ToString());
                int idStanica = Int32.Parse(this.textBoxIdStanice.Text);
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                try { veza.unsetTrasaStanica(idTrasaStanica);}
                catch (Exception ex) { }
                try { veza.unsetStanica(idStanica); }
                catch (Exception ex) { }

                this.textBoxIdStanice.Text = "";
                this.textBoxImeStanice.Text = "";
                this.textBoxKmDo.Text = "";
                this.textBoxKmOd.Text = "";
                this.comboBoxTrase.SelectedIndex = 0;
                this.comboBoxStanice.SelectedIndex = 0;
                this.popuniStanice();
                this.popuniTrase(this.comboBoxTrase);
                this.sveStanice(this.comboBoxPocetnaStanica);
                this.sveStanice(this.comboBoxKrajnjaStanica);
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
                this.comboBoxTrase.SelectedValue = 0;
                this.textBoxIdStanice.Text = "";
            }
            else
            {
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();

                string result = veza.getTrasaStanica(Int32.Parse(this.comboBoxStanice.SelectedValue.ToString()));
                this.textBoxImeStanice.Text = result.Split('_')[0].Split('@')[0];
                this.comboBoxTrase.SelectedValue = Int32.Parse(result.Split('_')[5]);
                this.textBoxKmOd.Text = result.Split('_')[3];
                this.textBoxKmDo.Text = result.Split('_')[4];
                this.textBoxIdStanice.Text = result.Split('_')[6];

            }
        }

        #endregion

        #region Trase

        private void buttonSacuvajTrasu_Click(object sender, EventArgs e)
        {
            string pocetna = this.comboBoxPocetnaStanica.Text;
            string krajnja = this.comboBoxKrajnjaStanica.Text;
            string ukupnoKm = this.textBoxUkupnoKm.Text;
            string zaSlanje = pocetna + "_" + krajnja + "_" + ukupnoKm;
            if (this.comboBoxIzaberiTrasu.SelectedIndex != 0)
            {
                int idTrasa = Int32.Parse(this.comboBoxIzaberiTrasu.SelectedValue.ToString());
                zaSlanje += "_" + idTrasa;
            }
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
            try { veza.setTrasa(zaSlanje); }
            catch (Exception ex) {}
            this.ponistiTrase();
            this.popuniTrase(this.comboBoxIzaberiTrasu);
            this.popuniTrase(this.comboBoxTrase);

        }

        private void buttonIzbrisiTrasu_Click(object sender, EventArgs e)
        {
            if (this.comboBoxIzaberiTrasu.SelectedIndex > 0)
            {
                int idTrasa = Int32.Parse(this.comboBoxIzaberiTrasu.SelectedValue.ToString());
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                try { veza.unsetTrasa(idTrasa); }
                catch (Exception ex) { }
                this.popuniStanice();
                this.ponistiTrase();
                this.popuniTrase(this.comboBoxIzaberiTrasu);
                this.popuniTrase(this.comboBoxTrase);
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
                this.ponistiTrase();
            }
            else
            {
                AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();
                string result = veza.getTrasu(Int32.Parse(this.comboBoxIzaberiTrasu.SelectedValue.ToString()));
                this.comboBoxPocetnaStanica.SelectedValue = Int32.Parse(result.Split('_')[0]);
                this.comboBoxKrajnjaStanica.SelectedValue = Int32.Parse(result.Split('_')[1]);
                this.textBoxUkupnoKm.Text = result.Split('_')[2];
            }
        }

        #endregion

        #region Dodatne funkcije

        private void popuniStanice()
        {
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();

            string result = veza.getTrasaStanice();
            string[] array = result.Split('#');
            Dictionary<int, string> staniceTrase = new Dictionary<int, string>();
            staniceTrase.Add(0, "Izaberi...");
            int count = array.Count();
            for (int i = 0; i < count - 1; i++)
            {
                string[] elements = array[i].Split('_');
                staniceTrase.Add(Int32.Parse(elements[1]), elements[0]);
            }
            this.comboBoxStanice.DataSource = new BindingSource(staniceTrase, null);
            this.comboBoxStanice.DisplayMember = "Value";
            this.comboBoxStanice.ValueMember = "Key";
        }
        private void popuniTrase(ComboBox cb){
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();

            string result = veza.getTrase();
            string[] array = result.Split('#');
            Dictionary<int, string> trase = new Dictionary<int, string>();
            trase.Add(0, "Izaberi...");
            int count = array.Count();
            for (int i = 0; i < count - 1; i++)
            {
                string[] elements = array[i].Split('_');
                trase.Add(Int32.Parse(elements[0]), elements[1] + "-" + elements[2]);
            }
            cb.DataSource = new BindingSource(trase, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }
        private void sveStanice(ComboBox cb)
        {
            AdminService.Ekarta_AdminPortClient veza = new AdminService.Ekarta_AdminPortClient();

            string result = veza.getStanice();
            string[] array = result.Split('#');
            Dictionary<int, string> trase = new Dictionary<int, string>();
            trase.Add(0, "Izaberi...");
            int count = array.Count();
            for (int i = 0; i < count - 1; i++)
            {
                string[] elements = array[i].Split('_');
                trase.Add(Int32.Parse(elements[0]), elements[1]);
            }
            cb.DataSource = new BindingSource(trase, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
        }
        private void ponistiTrase()
        {
            this.comboBoxIzaberiTrasu.SelectedIndex = 0;
            this.comboBoxPocetnaStanica.SelectedValue = 0;
            this.comboBoxKrajnjaStanica.SelectedValue = 0;
            this.textBoxUkupnoKm.Text = "";
        }

        #endregion
    }
}
