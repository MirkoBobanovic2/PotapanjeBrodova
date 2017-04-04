﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;


namespace Test
{
    [TestClass]
    public class TestMreže
    {
        [TestMethod]
        public void Mreža_DajSlobodnaPoljaVraćaSvaPoljaZaPočetnuMrežu()
        {
            Mreža m = new Mreža(5, 5);
            Assert.AreEqual(25, m.DajSlobodnaPolja().Count());
        }

        [TestMethod]
        public void Mreža_DajSlobodnaPoljaVraćaS24PoljaZaMrežu5x5NakonJednogUklonjenogPoljaZadanogRetkomIStupcem()
        {
            Mreža m = new Mreža(5, 5);
            m.UkloniPolje(1, 1);
            Assert.AreEqual(24, m.DajSlobodnaPolja().Count());
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(1, 1)));
        }

        [TestMethod]
        public void Mreža_DajSlobodnaPoljaVraćaS24PoljaZaMrežu5x5NakonJednogUklonjenogPolja()
        {
            Mreža m = new Mreža(5, 5);
            m.UkloniPolje(new Polje(1, 1));
            Assert.AreEqual(24, m.DajSlobodnaPolja().Count());
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(1, 1)));
        }
        [TestMethod]
        public void Mreža_DajSlobodnaPoljaVraćaS23PoljaZaMrežu5x5NakonDvaUklonjenogPolja()
        {
            Mreža m = new Mreža(5, 5);
            m.UkloniPolje(1, 1);
            m.UkloniPolje(4, 4);
            Assert.AreEqual(23, m.DajSlobodnaPolja().Count());
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(1, 1)));
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(4, 4)));
        }

        [TestMethod]
       
        public void Mreža_UkloniPoljeBacaIznimkuZaNepostojećiRedak()
        {
            try
            {
                Mreža m = new Mreža(5, 5);
                m.UkloniPolje(6, 1);
                Assert.Fail();
            }
            catch(IndexOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
            catch(Exception)
            {
                Assert.Fail();
            }
           
        }

        [TestMethod]

        public void Mreža_UkloniPoljeBacaIznimkuZaNepostojećiStupac()
        {
            try
            {
                Mreža m = new Mreža(5, 5);
                m.UkloniPolje(1, 6);
                Assert.Fail();
            }
            catch (IndexOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }

        }


        [TestMethod]
        public vid Mreža_DajNizovePoljaVraća3NizaZaBrodDuljine3UHorizontalnomRetkuDuljine5()
        {
            Mreža m = new Mreža(1, 5);
            Assert.AreEqual(3, m.DajNizoveSlobodnihPolja(3).Count());
        }

        [TestMethod]
        public vid Mreža_DajNizovePoljaVraćaPrazanNizZaBrodDuljine5UHorizontalnomRetkuDuljine4()
        {
            Mreža m = new Mreža(1, 4);
            Assert.AreEqual(0, m.DajNizoveSlobodnihPolja(5).Count());
        }


        [TestMethod]
        public vid Mreža_DajNizovePoljaVraća3NizaZaBrodDuljine3UVertikalnomStupcuDuljine5()
        {
            Mreža m = new Mreža(5, 1);
            Assert.AreEqual(3, m.DajNizoveSlobodnihPolja(3).Count());
        }

        [TestMethod]
        public vid Mreža_DajNizovePoljaVraćaPrazanNizZaBrodDuljine5UVertikalnomStupcuDuljine4()
        {
            Mreža m = new Mreža(4, 1);
            Assert.AreEqual(0, m.DajNizoveSlobodnihPolja(5).Count());
        }
    }
}
