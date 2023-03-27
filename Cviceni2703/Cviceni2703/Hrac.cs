using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2703
{
    internal class Hrac
    {

        private string jmeno;
        private int zdravi;
        private bool zivy;
        private Object o = new object();

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public int Zdravi
        {
            get { return zdravi; }
            set { zdravi = value; }
        }

        public bool Zivy
        {
            get { return zivy; }
            set { zivy = value; }
        }

        public Hrac(string jm, int zdr, bool ziv)
        {
            Jmeno = jm;
            Zdravi = zdr;
            Zivy = ziv;
        }

        public void Sniz(int cislo)
        {
            lock (o)
            {
                if (Zivy && Zdravi> 0)
                {
                    Zdravi -= cislo;
                }else if (Zdravi < 0)
                {
                    Zivy = false;
                    Zdravi = 0;
                }
            }
           
        }

        public void Zvys(int cislo)
        {
            lock (o)
            {
                if (Zivy && Zdravi > 0)
                {
                    Zdravi += cislo;
                }
                else if (Zdravi < 0)
                {
                    Zivy = false;
                    Zdravi= 0;
                }
            }
        }

        public override string ToString()
        {
            return "Hrac " + Jmeno + ", zdravi: " + Zdravi + ", je zivy: " + Zivy;
        }


    }
}
