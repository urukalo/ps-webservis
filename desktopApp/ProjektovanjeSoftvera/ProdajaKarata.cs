using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektovanjeSoftvera
{
    class ProdajaKarata
    {
        private int idT;
        private string nazivT;
        private int idPS;
        private string nazivPS;
        private int idDS;
        private string nazivDS;
        private int idV;
        private string vreme;
        private int idP;
        private string nazivP;
        private DateTime datum;
        private string imePrezime;
        private string telefon;
        private double popust;

        public int IdT
        {
            get { return idT; }
            set { idT = value; }
        }
        
        public string NazivT
        {
            get { return nazivT; }
            set { nazivT = value; }
        }
       
        public int IdPS
        {
            get { return idPS; }
            set { idPS = value; }
        }

        public string NazivPS
        {
            get { return nazivPS; }
            set { nazivPS = value; }
        }
        
        public int IdDS
        {
            get { return idDS; }
            set { idDS = value; }
        }
       
        public string NazivDS
        {
            get { return nazivDS; }
            set { nazivDS = value; }
        }
        
        public int IdV
        {
            get { return idV; }
            set { idV = value; }
        }
        
        public string Vreme
        {
            get { return vreme; }
            set { vreme = value; }
        }
       
        public int IdP
        {
            get { return idP; }
            set { idP = value; }
        }
        
        public string NazivP
        {
            get { return nazivP; }
            set { nazivP = value; }
        }
       
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        
        public string ImePrezime
        {
            get { return imePrezime; }
            set { imePrezime = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
       
        public double Popust
        {
            get { return popust; }
            set { popust = value; }
        }
    }
}
