using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjektovanjeSoftvera.AdminService;

namespace ProjektovanjeSoftvera
{
    public partial class PronadjiKartu : Form
    {
        public PronadjiKartu()
        {
            InitializeComponent();
        }

        private void buttonPronadji_Click(object sender, EventArgs e)
        {
            if (this.textBoxIdKarte.Text != "")
            {
                Ekarta_AdminPortClient veza = new Ekarta_AdminPortClient();
                string result = veza.getKarta(Int32.Parse(this.textBoxIdKarte.Text));
                if (result != "_")
                {
                    string[] array = result.Split('_');
                    this.textBoxPolazak.Text = array[0];
                    this.textBoxDolazak.Text = array[1];
                    this.textBoxTrasa.Text = array[2];
                    this.textBoxVremePolaska.Text = array[3];
                    this.textBoxCena.Text = array[4];
                    this.textBoxPopust.Text = array[5];
                    this.textBoxAktivna.Text = array[6] == "0" ? "Ne" : "Da";
                    this.textBoxPovratna.Text = array[7] == "0" ? "Ne" : "Da";
                }
                else
                {
                    MessageBox.Show("Ne postoji karta sa ovim identifikacionim brojem!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBoxIdKarte.Focus();
                }
            }
            else
            {
                MessageBox.Show("Unesite identifikacioni broj karte!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBoxIdKarte.Focus();
            }
        }

        private void buttonPlati_Click(object sender, EventArgs e)
        {
            if (this.textBoxIdKarte.Text != "")
            {
                if (this.textBoxPolazak.Text != "")
                {
                    if (this.textBoxAktivna.Text == "Ne")
                    {
                        Ekarta_AdminPortClient veza = new Ekarta_AdminPortClient();
                        try { veza.activate(Int32.Parse(this.textBoxIdKarte.Text)); }
                        catch (Exception ex) { }
                        this.textBoxAktivna.Text = "Da";
                        MessageBox.Show("Kartaje aktivirana!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Karta je vec placena!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji karta sa ovim identifikacionim brojem!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Unesite identifikacioni broj karte!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            if (this.textBoxIdKarte.Text != "")
            {
                if (this.textBoxPolazak.Text != "")
                {
                    Ekarta_AdminPortClient veza = new Ekarta_AdminPortClient();
                    try { veza.unsetKarta(Int32.Parse(this.textBoxIdKarte.Text)); }
                    catch (Exception ex) { }
                    MessageBox.Show("Karta je Izbrisana!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isprazniSvaPolja();
                }
                else
                {
                    MessageBox.Show("Ne postoji karta sa ovim identifikacionim brojem!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Unesite identifikacioni broj karte!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void isprazniSvaPolja()
        {
            this.textBoxIdKarte.Text = "";
            this.textBoxPolazak.Text = "";
            this.textBoxDolazak.Text = "";
            this.textBoxTrasa.Text = "";
            this.textBoxVremePolaska.Text = "";
            this.textBoxCena.Text = "";
            this.textBoxPopust.Text = "";
            this.textBoxAktivna.Text = "";
            this.textBoxPovratna.Text = "";
        }

    }
}
