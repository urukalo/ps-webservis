using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ProjektovanjeSoftvera.WebServis;

namespace ProjektovanjeSoftvera
{
    public partial class Form1 : Form
    {

        //Ekarta_ServisService servis = new Ekarta_ServisService();
       // Ekarta_karta karta = new Ekarta_karta();

        public Form1()
        {
            InitializeComponent();
            //Dictionary<int, string> popust = new Dictionary<int, string>();
            //Ekarta_ddlData popusti = servis.popusti();
            //popust = servis.popusti().to
         //   MessageBox.Show(popusti.value);
           //string[] arr = servis.popusti().Split('#');
            //comboBoxVrstaPopust.DataSource = servis.popusti();

           
           // myStrings = servis.popusti();

            //ComboBox ddl = new ComboBox();

            //ddl = (ComboBox)Form1. Row.FindControl("ddlMyStrings");
           
           // comboBoxVrstaPopust.DataSource = myStrings;

          //  comboBoxVrstaPopust.DataBind();
           

        }

        private void checkBoxPopust_CheckedChanged(object sender, EventArgs e)
        {
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
            tis.Show();
        }

        private void redVoznjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedVoznje redVoznje = new RedVoznje();
            redVoznje.Show();
        }

        private void administracijaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
