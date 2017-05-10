using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{

    public enum TaktikaGađanja
    {
        Nasumično,
        Kružno,
        Linijsko
    }

    public class Topništvo
    {
        public Topništvo(int redaka, int stupaca, IEnumerable<int> duljineBrodova)
        {
            mreža = new Mreža(redaka, stupaca);
            this.DuljineBrodova = new List<int>(duljineBrodova);
            TaktikaGađanja = TaktikaGađanja.Nasumično;
            pucač = new SlučajniPucač(mreža, duljineBrodova.First());
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            if (rezultat == RezultatGađanja.Promašaj)
                return;
            if (rezultat== RezultatGađanja.Pogodak)
            {
                switch(TaktikaGađanja)
                {
                    case TaktikaGađanja.Nasumično:
                        PromijeniTaktikuUKružno();
                        return;
                    case TaktikaGađanja.Kružno:
                        PromijeniTaktikuULinijsko();
                        return;

                    case TaktikaGađanja.Linijsko:
                        return;
                    default:
                        Debug.Assert(false);
                        break;

                }
            }
            Debug.Assert(rezultat == RezultatGađanja.Potopljen);
            PromijeniTaktikuUNasumično();

        }

        private void PromijeniTaktikuUKružno()
        {
            TaktikaGađanja = TaktikaGađanja.Kružno;
            Polje Pogođeno = pucač.PogođenaPolja.First();
            pucač = new KružniPucač(mreža, Pogođeno, DuljineBrodova.First());
        }

        private void PromijeniTaktikuULinijsko()
        {
            TaktikaGađanja = TaktikaGađanja.Linijsko;
            var Pogođeno = pucač.PogođenaPolja;
            pucač = new LinijskiPucač(mreža, Pogođeno, DuljineBrodova.First());
        }

        private void PromijeniTaktikuUNasumično()
        {
            TaktikaGađanja = TaktikaGađanja.Nasumično;
            pucač = new SlučajniPucač(mreža,  DuljineBrodova.First());
        }

        public TaktikaGađanja TaktikaGađanja { get; private set; }

        private Mreža mreža;
        private List<int> DuljineBrodova;
        private IPucač pucač;
       
    }
}
