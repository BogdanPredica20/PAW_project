using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Film
    {
        public string nume_film;
        public string gen;
        public char rating;
        public int durata;
        public DateTime data_premierei;
        public int stoc;

        public Film(string n, string g, char r, int d, DateTime da, int s)
        {
            nume_film = n;
            gen = g;
            rating = r;
            durata = d;
            data_premierei = da;
            stoc = s;
        }

        public Film()
        {
            nume_film = " ";
            gen = " ";
            rating = ' ';
            durata = 0;
            data_premierei = DateTime.Now;
            stoc = 0;
        }

    }
}
