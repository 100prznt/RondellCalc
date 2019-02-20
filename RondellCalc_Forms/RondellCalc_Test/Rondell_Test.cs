using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RondellCalc_Forms;

namespace RondellCalc_Test
{
    [TestClass]
    public class Rondell_Test
    {
        Rondell m_TestObj = new Rondell()
        {
            StoneCount = 16,
            StoneLengthA = 40,
            StoneLengthB = 40,
            ConcreteWidth = 10
        };

        [TestMethod]
        public void SegmentAngle()
        {
            Assert.AreEqual(22.5, m_TestObj.SegmentAngle);
        }

        [TestMethod]
        public void MaxRadius()
        {
            //Referenzergebnis von: HP Prime Graphing Calculator - Dreiecklöser (App)
            Assert.AreEqual(1.0452503719, m_TestObj.MaxRadius, 1e-9);
        }

        [TestMethod]
        public void MinRadius()
        {
            //Referenzergebnis von: HP Prime Graphing Calculator - Dreiecklöser (App)
            Assert.AreEqual(0.965685424949, m_TestObj.MinRadius, 1e-9);
        }

        [TestMethod]
        public void MaxDiameter()
        {
            //Referenzergebnis von: HP Prime Graphing Calculator
            Assert.AreEqual(2.0905007438, m_TestObj.MaxDiameter, 1e-9);
        }

        [TestMethod]
        public void MinDiameter()
        {
            //Referenzergebnis von: HP Prime Graphing Calculator
            Assert.AreEqual(1.931370849898, m_TestObj.MinDiameter, 1e-9);
        }

        [TestMethod]
        public void SingleStoneArea()
        {
            //Referenzergebnis von: HP Prime Graphing Calculator
            Assert.AreEqual(0.12686291501, m_TestObj.SingleStoneArea, 1e-9);
        }

        [TestMethod]
        public void StoneArea()
        {
            //Referenzergebnis von: HP Prime Graphing Calculator
            Assert.AreEqual(2.02980664016, m_TestObj.StoneArea, 1e-9);
        }

        [TestMethod]
        public void ConcreteVolume()
        {
            //Referenzergebnis von: HP Prime Graphing Calculator
            Assert.AreEqual(0.202980664016, m_TestObj.ConcreteVolume, 1e-9);
        }
    }
}
