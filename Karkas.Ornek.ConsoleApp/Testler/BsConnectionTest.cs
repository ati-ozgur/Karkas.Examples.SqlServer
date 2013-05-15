using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Karkas.Ornek.TypeLibrary.Ornekler;
using Karkas.Ornek.Bs.Ornekler;

namespace Karkas.Ornek.ConsoleApp.Testler
{
    [TestFixture]
    public class BsConnectionTest
    {
        [Test]
        public void Ekle()
        {
            MusteriBs wrapper = new MusteriBs();
            Musteri m = new Musteri();
            m.MusteriKey = Guid.NewGuid();

            m.Adi = "Atilla";
            m.Soyadi = "Ozgur";

            wrapper.Ekle(m);
        }
    }
}

