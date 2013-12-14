using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektovanjeSoftvera
{
    class Stanice
    {
        private int idTrasa;
        private string nazivStanice;
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

        public int IdTrasa
        {
            get { return idTrasa; }
            set { idTrasa = value; }
        }

        public string NazivStanice
        {
            get { return nazivStanice; }
            set { nazivStanice = value; }
        }
    }
}
