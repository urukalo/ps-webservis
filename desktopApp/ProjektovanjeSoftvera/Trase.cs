using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektovanjeSoftvera
{
    class Trase
    {
        private string pocetnaS;
        private string krajnjaS;
        private int idT;
        private string nazivT;

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

        public string KrajnjaS
        {
            get { return krajnjaS; }
            set { krajnjaS = value; }
        }

        public string PocetnaS
        {
            get { return pocetnaS; }
            set { pocetnaS = value; }
        }
    }
}
