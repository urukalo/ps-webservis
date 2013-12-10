using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektovanjeSoftvera
{
    class Stanice
    {
        private string nazivS;
        private int idT;
        private string nazivT;
        private int kmOd;
        private int kmDo;

        public int KmDo
        {
            get { return kmDo; }
            set { kmDo = value; }
        }

        public int KmOd
        {
            get { return kmOd; }
            set { kmOd = value; }
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

        public string NazivS
        {
            get { return nazivS; }
            set { nazivS = value; }
        }
    }
}
