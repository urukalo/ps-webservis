using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektovanjeSoftvera
{
    class ObrisiTrasu
    {
        private int idSu;
        private string nazivSu;
        private int idSi;
        private string nazivSi;

        public string NazivSi
        {
            get { return nazivSi; }
            set { nazivSi = value; }
        }

        public int IdSi
        {
            get { return idSi; }
            set { idSi = value; }
        }

        public string NazivSu
        {
            get { return nazivSu; }
            set { nazivSu = value; }
        }

        public int IdSu
        {
            get { return idSu; }
            set { idSu = value; }
        }
    }
}
