using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Flota : IGađani
    {
        public void DodajBrod(IEnumerable<Polje> polja)
        {
            brodovi.Add(new Brod(polja));
        }

        public RezultatGađanja Gađaj(Polje polje)
        {
            foreach (Brod brod in brodovi)
            {
                var Rezultat = brod.Gađaj(polje);
                if (Rezultat != RezultatGađanja.Promašaj)
                    return Rezultat;
            }
            return RezultatGađanja.Promašaj;
        }

        public int BrojBrodova
        {
            get { return brodovi.Count; }
        }

        private List<Brod> brodovi = new List<Brod>();
    }
}