using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {
        public KružniPucač(Mreža mreža,  Polje Pogođeno, int duljinaBroda)
        {
            this.mreža = mreža;
            this.prvoPogođenoPolje = Pogođeno;
            this.duljinaBroda = duljinaBroda;

        }
        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private Mreža mreža;
            private Polje prvoPogođenoPolje;
        private int duljinaBroda;

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
