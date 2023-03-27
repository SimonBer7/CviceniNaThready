using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2003
{
    internal class System
    {
        private List<Uzivatel> systemos;

        public List<Uzivatel> Systemos
        {
            get { return systemos; }
            set { systemos = value; }
        }

        public System()
        {
            Systemos = new List<Uzivatel>();
        }


        public bool Check(string jm)
        {
            jm.ToLower();
            foreach (Uzivatel v in Systemos)
            {
                if (jm.Equals(v.Jmeno))
                {
                    return false;
                }
            }
            return true;
        }

        public void AddUzivatel(Uzivatel u)
        {
            if(Check(u.Jmeno) == true)
            {
                Systemos.Add(u);
            }
        }

        public string NajdiPodlePrav(Prava p)
        {
            
            string vypis = "";
            foreach (Uzivatel v in Systemos)
            {
                if(v.Prava == p)
                {
                    vypis += v.ToString()+"\n";
                }
            }
            return vypis;
        }

        public string NajdiPrvnihoPodleHesla()
        {
            string vypis = "";
            vypis += Systemos[0].ToString()+"\n";
            return vypis;   
        }


    }
}
