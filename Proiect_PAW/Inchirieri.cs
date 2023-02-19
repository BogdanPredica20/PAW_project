using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Inchirieri
    {
        public Client client;
        public Film film;
        public int pret;
        public DateTime data_inchirierii;
        public int durata_inchirierii;

        public Inchirieri(Client c, Film f, int p, DateTime d, int durata)
        {
            client = c;
            film = f;
            pret = p;
            data_inchirierii = d;
            durata_inchirierii = durata;
        }

        public Inchirieri()
        {

        }

        public int verifica_stoc()
        {
            if (film.stoc != 0)
                return 1;
            else
                return 0;
        }

    }
}
