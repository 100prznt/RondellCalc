using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RondellCalc_Forms;

namespace RondellCalc_Test
{
    [TestClass]
    public class Controller_Test
    {
        Controller m_TestObj = new Controller();

        [TestMethod]
        public void CalcConcretePacks()
        {
            //Referenzergebnis von: HP Prime Graphing Calculator
            Assert.AreEqual(32, m_TestObj.CalcConcretePacks(0.5, 30));
        }
    }
}
