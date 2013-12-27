using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ProjektovanjeSoftvera
{
    public partial class Privremen : Form
    {
        public Privremen()
        {
            InitializeComponent();
        }

        public string VoznaTrasa
        {
            set
            {
                Trasa.Text = value.ToString();
            }
        }

        public string PolaznaS
        {
            set
            {
                Polazna.Text = value;
            }
        }

        public string DatumP
        {
            set
            {
                Datum.Text = value;
            }
        }

        public string VremeP
        {
            set
            {
                Vreme.Text = value;
            }
        }

        public string DolaznaS
        {
            set
            {
                Dolazna.Text = value;
            }
        }

        public string PopustP
        {
            set
            {
                Popust.Text = value;
            }
        }

        public string PovratnaP
        {
            set
            {
                Povratna.Text = value;
            }
        }

        public Image QR
        {
            set
            {
                pictureBox1.Image = value;
            }
        }

        private void Privremen_Load(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            PrintPreviewDialog ppdlg = new PrintPreviewDialog();
            ppdlg.Document = pd;
            ppdlg.ShowDialog();
        }

        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width - 50, height - 50);
            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(-10, -50);
            e.Graphics.DrawImage(img, p);
        }
    }
}
