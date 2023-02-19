using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Client
    {
        public string nume;
        public string prenume;
        public int varsta;
        public string cnp;
        public string oras;

        public Client(string n, string p, int v, string c, string o)
        {
            nume = n;
            prenume = p;
            varsta = v;
            cnp = c;
            oras = o;
        }

        public Client()
        {
            nume = " ";
            prenume = " ";
            varsta = 0;
            cnp = " ";
            oras = " ";
        }
    }
}
