using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class LinijskiPucač : IPucač
    {
        private Mreža mreža;
        private IEnumerable<Polje> pogođenaPolja;
        private int duljinaBroda;

        public LinijskiPucač(Mreža mreža, IEnumerable<Polje> Pogođeno, int duljinaBroda)
        {
            this.mreža = mreža;
            this.pogođenaPolja = Pogođeno;
            this.duljinaBroda = duljinaBroda;

        }
        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public Polje Gađaj()
        {
            throw new NotImplementedException();
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }
    }
}
