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

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate19000101()
        {
            Data data = new Data(1, 1, 1900);
            data.OdejmnijMiesiac();

            Assert.AreEqual("1899121", data.ToStringRRMMDD());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20121215()
        {
            Data data = new Data(15, 12, 2012);
            data.DodajMiesiac();

            Assert.AreEqual("2013115", data.ToStringRRMMDD());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20151201()
        {
            Data data = new Data(1, 12, 2015);
            data.DodajMiesiac();
            Assert.AreEqual("201611", data.ToStringRRMMDD());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20130122()
        {
            Data data = new Data(22, 1, 2013);
            data.OdejmnijMiesiac();
            Assert.AreEqual("20121222", data.ToStringRRMMDD());
            
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190522()
        {
            Data data = new Data(22, 5, 2019);
            data.DodajMiesiac();
            Assert.AreEqual("2019622", data.ToStringRRMMDD());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20170613()
        {
            Data data = new Data(13, 6, 2017);
            data.OdejmnijMiesiac();
            Assert.AreEqual("2017513", data.ToStringRRMMDD());

        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20140315()
        {
            Data data = new Data(15, 3, 2014);
            data.DodajRok();
            Assert.AreEqual("2015315", data.ToStringRRMMDD());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20130315()
        {
            Data data = new Data(15, 3, 2013);
            data.OdejmnijRok();
            Assert.AreEqual("2012315", data.ToStringRRMMDD());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20110101()
        {
            Data data = new Data(1, 1, 2011);
            data.DodajRok();
            Assert.AreEqual("201211", data.ToStringRRMMDD());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20081231()
        {
            Data data = new Data(31, 12, 2008);
            data.DodajRok();
            Assert.AreEqual("20091231", data.ToStringRRMMDD());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20061231()
        {
            Data data = new Data(31, 12, 2006);
            data.OdejmnijRok();
            Assert.AreEqual("20051231", data.ToStringRRMMDD());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20200301()
        {
            Data data = new Data(1, 3, 2020);
            data.OdejmnijDzien();
            Assert.AreEqual("2020229", data.ToStringRRMMDD());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190301()
        {
            Data data = new Data(1, 3, 2019);
            data.OdejmnijDzien();
            Assert.AreEqual("2019228", data.ToStringRRMMDD());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20200130()
        {
            Data data = new Data(30, 1, 2020);
            data.DodajMiesiac();
            Assert.AreEqual("2020229", data.ToStringRRMMDD());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190330()
        {
            Data data = new Data(30, 3, 2019);
            data.OdejmnijMiesiac();
            Assert.AreEqual("2019228", data.ToStringRRMMDD());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190331()
        {
            Data data = new Data(31, 3, 2019);
            data.DodajMiesiac();
            Assert.AreEqual("2019430", data.ToStringRRMMDD());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190531()
        {
            Data data = new Data(31, 5, 2019);
            data.OdejmnijMiesiac();
            Assert.AreEqual("2019430", data.ToStringRRMMDD());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20191130()
        {
            Data data = new Data(30, 11, 2019);
            data.OdejmnijMiesiac();
            Assert.AreEqual("20191030", data.ToStringRRMMDD());
        }
    }
}
