using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JaratKezelo.Tests
{
    [TestFixture]
    class JaratTest
    {
        JaratKezelo j;

        [SetUp]
        public void Setup()
        {
            j = new JaratKezelo();
        }

        

        [Test]
        public void Keses()
        {
            j.UjJarat("999", "Budapest", "London", new DateTime(2019, 04, 10, 9, 10, 20),0);
            test = j.Keses("999", 30, new DateTime(2019, 04, 10, 9, 40, 20));
            Assert.AreEqual("999", "Budapest", "London", new DateTime(2019, 04, 10, 9, 10, 20), test);
        }
    }
}
