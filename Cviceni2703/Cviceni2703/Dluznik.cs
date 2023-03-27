using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2703
{
    internal class Dluznik
    {
        private int id;
        private string rodneCislo;
        private int castka;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string RdneCislo
        {
            get { return rodneCislo; }
            set { rodneCislo = value; }
        }

        public int Castka
        {
            get { return castka; }
            set { castka = value; }
        }

        public Dluznik(int i, string rc, int c)
        {
            ID = i;
            RdneCislo = rc;
            Castka = c;
        }


        public override string ToString()
        {
            return "Dluznik ID: "+ID+", rodne cislo: "+RdneCislo+", castka: "+Castka;
        }




    }
}
