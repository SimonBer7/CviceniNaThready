using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePripravaNaThready
{
    internal class Citac
    {

        private int hodnota;

        public int Hodnota
        {
            get { return hodnota; }
            set { hodnota = value; }
        }

        public void Zvys()
        {
            Hodnota++;
        }

        public void Sniz()
        {
            Hodnota--;
        }

        public Citac(int h)
        {
            Hodnota = h;    
        }

        public override string ToString()
        {
            return "Hodnota: " + Hodnota;
        }



    }
}
