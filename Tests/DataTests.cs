using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training;

namespace Tests
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void ObiektDatyUtworzonyDomyslnymKonstruktoremUstawiaDate18991231()
        {
            Data data = new Data();
            
            Assert.AreEqual("18991231", data.ToStringRRMMDD());
        }
    }
}
