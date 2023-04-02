using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePripravaNaThready
{
    internal class Hrac
    {

        private string jmeno;
        private int zdravi;
        private bool isAlive;
        private object lockObj = new object();

        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set { jmeno = value; }
        }

        public int Zdravi
        {
            get { return zdravi; }
            set { zdravi = value; }
        }

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }

        public Hrac(string jm, int zdr, bool isA)
        {
            Jmeno = jm;
            Zdravi = zdr;
            IsAlive = isA;
        }


        public void Zvys(int cislo)
        {
            if(cislo < 0)
            {
                cislo = cislo * (-1);
            }
            
            lock (lockObj) { 
            if(Zdravi >= 0 && IsAlive)
                Zdravi += cislo; 
            }
            
        }

        public void Sniz(int cislo)
        {

            if (cislo < 0)
            {
                cislo = cislo * (-1);
            }

            lock (lockObj) { 
            
            if(Zdravi >= 0 && IsAlive)
                {
                    Zdravi -= cislo;
                }
                
            }
        }


        public override string ToString()
        {
            return "Hrac " + Jmeno + ", zdravi: " + Zdravi + ", is alive: " + IsAlive;
        }


    }
}
