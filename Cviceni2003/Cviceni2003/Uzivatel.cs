using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2003
{
    public enum Prava
    {
        VELKY, STREDNI, MALY
    }

    internal class Uzivatel
    {

        private string jmeno;
        private string heslo;
        private Prava prava;


        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public string Heslo
        {
            get { return heslo; }
            set { heslo = value; }
        }

        public Prava Prava
        {
            get { return prava; }
            set { prava = value; }
        }
        
        public string HashingSimulator()
        {
            string hash = "";
            for (int i = 0; i < Heslo.Length; i++)
            {
                hash += "*";
            }
            return hash;
        }

        public override string ToString()
        {
            return "Uzivatel " + Jmeno + ", heslo: " + HashingSimulator() + ", prava: " + Prava;
        }

    }
}
