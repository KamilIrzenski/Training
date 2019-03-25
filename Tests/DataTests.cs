﻿using System;
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

            Assert.AreEqual("18991231", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate2019322()
        {
            Data data = new Data(22, 03, 2019,"YYYYMMDD");

            Assert.AreEqual("20190322", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate19000101()
        {
            Data data = new Data(1, 1, 1900,"YYYYMMDD");
            data.OdejmnijMiesiac();

            Assert.AreEqual("18991201", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20121215()
        {
            Data data = new Data(15, 12, 2012,"YYYYMMDD");
            data.DodajMiesiac();

            Assert.AreEqual("20130115", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20151201()
        {
            Data data = new Data(1, 12, 2015, "YYYYMMDD");
            data.DodajMiesiac();
            Assert.AreEqual("20160101", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20130122()
        {
            Data data = new Data(22, 1, 2013, "YYYYMMDD");
            data.OdejmnijMiesiac();
            Assert.AreEqual("20121222", data.ToString());
            
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190522()
        {
            Data data = new Data(22, 5, 2019, "YYYYMMDD");
            data.DodajMiesiac();
            Assert.AreEqual("20190622", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20170613()
        {
            Data data = new Data(13, 6, 2017, "YYYYMMDD");
            data.OdejmnijMiesiac();
            Assert.AreEqual("20170513", data.ToString());

        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20140315()
        {
            Data data = new Data(15, 3, 2014, "YYYYMMDD");
            data.DodajRok();
            Assert.AreEqual("20150315", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20130315()
        {
            Data data = new Data(15, 3, 2013, "YYYYMMDD");
            data.OdejmnijRok();
            Assert.AreEqual("20120315", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20110101()
        {
            Data data = new Data(1, 1, 2011, "YYYYMMDD");
            data.DodajRok();
            Assert.AreEqual("20120101", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20081231()
        {
            Data data = new Data(31, 12, 2008, "YYYYMMDD");
            data.DodajRok();
            Assert.AreEqual("20091231", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20061231()
        {
            Data data = new Data(31, 12, 2006, "YYYYMMDD");
            data.OdejmnijRok();
            Assert.AreEqual("20051231", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20200301()
        {
            Data data = new Data(1, 3, 2020, "YYYYMMDD");
            data.OdejmnijDzien();
            Assert.AreEqual("20200229", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190301()
        {
            Data data = new Data(1, 3, 2019, "YYYYMMDD");
            data.OdejmnijDzien();
            Assert.AreEqual("20190228", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20200130()
        {
            Data data = new Data(30, 1, 2020, "YYYYMMDD");
            data.DodajMiesiac();
            Assert.AreEqual("20200229", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190330()
        {
            Data data = new Data(30, 3, 2019, "YYYYMMDD");
            data.OdejmnijMiesiac();
            Assert.AreEqual("20190228", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190331()
        {
            Data data = new Data(31, 3, 2019, "YYYYMMDD");
            data.DodajMiesiac();
            Assert.AreEqual("20190430", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190531()
        {
            Data data = new Data(31, 5, 2019, "YYYYMMDD");
            data.OdejmnijMiesiac();
            Assert.AreEqual("20190430", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20191130()
        {
            Data data = new Data(30, 11, 2019, "YYYYMMDD");
            data.OdejmnijMiesiac();
            Assert.AreEqual("20191030", data.ToString());
        }

        [TestMethod]
        public void powinienWyswietlicDateWFormacieRRRRMMDD_1()
        {
            Data data = new Data(1, 1, 2019, "YYYYMMDD");
            Assert.AreEqual("20190101", data.ToString());
        }

        [TestMethod]
        public void powinienWyswietlicDateWFormacieRRRRMMDD_2()
        {
            Data data = new Data(12, 1, 2019 , "YYYYMMDD");
            Assert.AreEqual("20190112", data.ToString());
        }

        [TestMethod]
        public void powinienWyswietlicDateWFormacieRRRRMMDD_3()
        {
            Data data = new Data(1, 10, 2019, "YYYYMMDD");
            Assert.AreEqual("20191001", data.ToString());
        }

        [TestMethod]
        public void powinienWyswietlicDateWFormacieDDMMRRRR()
        {
            Data data = new Data(2, 2, 2015,"DDMMYYYY");
            Assert.AreEqual("02022015", data.ToString());
        }
        [TestMethod]
        public void WKlasieStringMoznaWywolacToStringIPodacFormatDatyPrzezKonstruktor()
        {
            Data data = new Data(7, 12, 2020, "YYYYMMDD");
            Assert.AreEqual("20201207", data.ToString());
        }

        [TestMethod]
        public void WKlasieStringMoznaWywolacToStringIPodacFormatDatyPrzezKonstruktor_2()
        {
            Data data = new Data(7, 12, 2020, "DDMMYYYY");
            Assert.AreEqual("07122020", data.ToString());
        }
        [TestMethod]
        public void WKlasieStringMoznaWywolacToStringIPodacFormatDatyPrzezKonstruktor_3()
        {
            Data data = new Data(7, 12, 2020, "MMDDYYYY");
            Assert.AreEqual("12072020", data.ToString());
        }


    }
}
