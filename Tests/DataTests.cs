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

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate2019322()
        {
            Data data = new Data(22, 03, 2019);

            Assert.AreEqual("2019322", data.ToStringRRMMDD());
        }
    }
}
