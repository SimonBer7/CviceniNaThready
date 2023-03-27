using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2703
{
    internal class Evidence
    {

        private List<Dluznik> list;

        public List<Dluznik> List
        {
            get { return list; }
            set
            {
                list = value;
            }
        }

        public Evidence()
        {
            list = new List<Dluznik>();
            ReadFromFile();
        }

        public void AddDluznik(Dluznik d)
        {
            List.Add(d);
        }

        public void ReadFromFile()
        {
            int index = 0;
            using(var reader = new StreamReader("dluznici.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (index != 0)
                    {
                        line = reader.ReadLine();
                        var values = line.Split(';');
                        int id = Int32.Parse(values[0]);
                        string rodneCislo = values[1].ToString();
                        int castka = Int32.Parse(values[2]);
                        Dluznik d = new Dluznik(id, rodneCislo, castka);
                        AddDluznik(d);
                    }
                    
                    index++;

                }
            }
        }

        public override string ToString()
        {
            string vypis = "";
            foreach (Dluznik d in list)
            {
                vypis += d.ToString + "'\n";
            }
            return vypis;
        }

    }
}
