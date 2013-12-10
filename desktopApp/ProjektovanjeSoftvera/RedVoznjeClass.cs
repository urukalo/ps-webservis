using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektovanjeSoftvera
{
    class RedVoznjeClass
    {
        private int idT;
        private string nazivT;
        private int idD;
        private string nazivD;
        private int sat;
        private int minut;

        public int Minut
        {
            get { return minut; }
            set { minut = value; }
        }

        public int Sat
        {
            get { return sat; }
            set { sat = value; }
        }

        public string NazivD
        {
            get { return nazivD; }
            set { nazivD = value; }
        }

        public int IdD
        {
            get { return idD; }
            set { idD = value; }
        }

        public string NazivT
        {
            get { return nazivT; }
            set { nazivT = value; }
        }

        public int IdT
        {
            get { return idT; }
            set { idT = value; }
        }
    }
}
