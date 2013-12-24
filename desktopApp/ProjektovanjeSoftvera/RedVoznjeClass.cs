using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjektovanjeSoftvera
{
    class RedVoznjeClass
    {
        private int idTrase;
        private string nazivTrase;
        private int idDan;
        private string nazivDan;
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

        public string NazivDan
        {
            get { return nazivDan; }
            set { nazivDan = value; }
        }

        public int IdDan
        {
            get { return idDan; }
            set { idDan = value; }
        }

        public string NazivTrasa
        {
            get { return nazivTrase; }
            set { nazivTrase = value; }
        }

        public int IdTrasa
        {
            get { return idTrase; }
            set { idTrase = value; }
        }
    }
}
