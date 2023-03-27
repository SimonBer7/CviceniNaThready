using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2003
{
    internal class Citac
    {

        private int cislo;

        public int Cislo
        {
            get { return cislo; }
            set { cislo = value; }
        }

        public Citac(int cislo)
        {
            Cislo = cislo;
        }

        public void Zvys()
        {
            Cislo++;
        }

        public void Sniz()
        {
            Cislo--;
        }

        public override string ToString()
        {
            return cislo.ToString();
        }

    }
}
