using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Obvod
{
    [TestFixture]
    class VypocetTest
    {
        [Test]
        public void ObvodTest()
        {
            Vypocet vyp = new Vypocet();
            int vysledok = vyp.vypocitaj(2, 4, 6);
            Assert.AreEqual(12, vysledok);
        }
    }
}
