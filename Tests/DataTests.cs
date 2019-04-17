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

            Assert.AreEqual("18991231", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate2019322()
        {
            Data data = new Data(22, 03, 2019, FormatDaty.YYYYMMDD);

            Assert.AreEqual("20190322", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate19000101()
        {
            Data data = new Data(1, 1, 1900, FormatDaty.YYYYMMDD);
            data.SubtractMonth();

            Assert.AreEqual("18991201", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20121215()
        {
            Data data = new Data(15, 12, 2012, FormatDaty.YYYYMMDD);
            data.AddMonth();

            Assert.AreEqual("20130115", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20151201()
        {
            Data data = new Data(1, 12, 2015, FormatDaty.YYYYMMDD);
            data.AddMonth();
            Assert.AreEqual("20160101", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20130122()
        {
            Data data = new Data(22, 1, 2013, FormatDaty.YYYYMMDD);
            data.SubtractMonth();
            Assert.AreEqual("20121222", data.ToString());
            
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190522()
        {
            Data data = new Data(22, 5, 2019, FormatDaty.YYYYMMDD);
            data.AddMonth();
            Assert.AreEqual("20190622", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20170613()
        {
            
            Data data = new Data(13, 6, 2017, FormatDaty.YYYYMMDD);
            data.SubtractMonth();
            Assert.AreEqual("20170513", data.ToString());

        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20140315()
        {
            Data data = new Data(15, 3, 2014, FormatDaty.YYYYMMDD);
            data.AddYear();
            Assert.AreEqual("20150315", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20130315()
        {
            Data data = new Data(15, 3, 2013, FormatDaty.YYYYMMDD);
            data.SubtractYear();
            Assert.AreEqual("20120315", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20110101()
        {
            Data data = new Data(1, 1, 2011, FormatDaty.YYYYMMDD);
            data.AddYear();
            Assert.AreEqual("20120101", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20081231()
        {
            Data data = new Data(31, 12, 2008, FormatDaty.YYYYMMDD);
            data.AddYear();
            Assert.AreEqual("20091231", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20061231()
        {
            Data data = new Data(31, 12, 2006, FormatDaty.YYYYMMDD);
            data.SubtractYear();
            Assert.AreEqual("20051231", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20200301()
        {
            Data data = new Data(1, 3, 2020, FormatDaty.YYYYMMDD);
            data.SubtractDay();
            Assert.AreEqual("20200229", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190301()
        {
            Data data = new Data(1, 3, 2019, FormatDaty.YYYYMMDD);
            data.SubtractDay();
            Assert.AreEqual("20190228", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20200130()
        {
            Data data = new Data(30, 1, 2020, FormatDaty.YYYYMMDD);
            data.AddMonth();
            Assert.AreEqual("20200229", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190330()
        {
            Data data = new Data(30, 3, 2019, FormatDaty.YYYYMMDD);
            data.SubtractMonth();
            Assert.AreEqual("20190228", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190331()
        {
            Data data = new Data(31, 3, 2019, FormatDaty.YYYYMMDD);
            data.AddMonth();
            Assert.AreEqual("20190430", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiDate25042000()
        {
            Data data = new Data(25, 05, 2000);
            data.SubtractMonth();
            Assert.AreEqual("25042000", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20190531()
        {
            Data data = new Data(31, 5, 2019, FormatDaty.YYYYMMDD);
            data.SubtractMonth();
            Assert.AreEqual("20190430", data.ToString());
        }

        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate20191130()
        {
            Data data = new Data(30, 11, 2019, FormatDaty.YYYYMMDD);
            data.SubtractMonth();
            Assert.AreEqual("20191030", data.ToString());
        }
        [TestMethod]
        public void ObiektDatyUtworzonyKonstruktoremZParametramiUstawiaDate31032000()
        {
            Data data = new Data(30, 03, 2000);
            data.AddDay();
            Assert.AreEqual("20000331", data.ToString());
        }

        [TestMethod]
        public void powinienWyswietlicDateWFormacieRRRRMMDD_1()
        {
            Data data = new Data(1, 1, 2019, FormatDaty.YYYYMMDD);
            Assert.AreEqual("20190101", data.ToString());
        }
        

        [TestMethod]
        public void powinienWyswietlicDateWFormacieRRRRMMDD_2()
        {
            Data data = new Data(12, 1, 2019 , FormatDaty.YYYYMMDD);
            Assert.AreEqual("20190112", data.ToString());
        }

        [TestMethod]
        public void powinienWyswietlicDateWFormacieRRRRMMDD_3()
        {
            Data data = new Data(1, 10, 2019, FormatDaty.YYYYMMDD);
            Assert.AreEqual("20191001", data.ToString());
        }

        [TestMethod]
        public void powinienWyswietlicDateWFormacieDDMMRRRR()
        {
            Data data = new Data(2, 2, 2015,FormatDaty.DDMMYYYY);
            Assert.AreEqual("02022015", data.ToString());
        }
        [TestMethod]
        public void WKlasieStringMoznaWywolacToStringIPodacFormatDatyPrzezKonstruktor()
        {
            Data data = new Data(7, 12, 2020, FormatDaty.YYYYMMDD);
            Assert.AreEqual("20201207", data.ToString());
        }

        [TestMethod]
        public void WKlasieStringMoznaWywolacToStringIPodacFormatDatyPrzezKonstruktor_2()
        {
            Data data = new Data(7, 12, 2020, FormatDaty.DDMMYYYY);
            Assert.AreEqual("07122020", data.ToString());
        }

        [TestMethod]
        public void WKlasieStringMoznaWywolacToStringIPodacFormatDatyPrzezKonstruktor_3()
        {
            Data data = new Data(7, 12, 2020, FormatDaty.MMDDYYYY);
            Assert.AreEqual("12072020", data.ToString());
        }
        [TestMethod]
        public void powinienRzucicWyjatekJezeliWprowadzonaDataMaNiepoprawnaIloscDniWMiesiacu()
        {
            try
            {
                Data data = new Data(31, 4, 2019);
            }
            catch
            {
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void powinienRzucicWyjatekJezeliWprowadzonaDataMaNiepoprawnaIloscDniWMiesiacu_2()
        {
            try
            {
                Data data = new Data(32, 3, 2019);
            }
            catch
            {
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void powinienRzucicWyjatekJezeliWprowadzonaDataMaNiepoprawnaIloscDniWMiesiacu_3()
        {
            try
            {
                Data data = new Data(0, 3, 2019);
            }
            catch
            {
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void powinienRzucicWyjatekJezeliWprowadzonaDataMaNiepoprawnaIloscDniWMiesiacu_4()
        {
            try
            {
                Data data = new Data(29, 2, 2019);
            }
            catch
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void powinienRzucicWyjatekJezeliWprowadzonaDataMaNiepoprawnaIloscDniWMiesiacu_5()
        {
            try
            {
                Data data = new Data(11, 13, 2019);
            }
            catch
            {
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void powinienRzucicWyjatekJezeliWprowadzonaDataMaNiepoprawnaIloscDniWMiesiacu_6()
        {
            try
            {
                Data data = new Data(11, -1, 2019);
            }
            catch
            {
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void powinienRzucicWyjatekJezeliWprowadzonaDataMaNiepoprawnaIloscDniWMiesiacu_7()
        {
            try
            {
                Data data = new Data();
                data.SetDate(11, -1, 2019);
            }
            catch
            {
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void powinienNieRzucicWyjatkuDlaLutegoWPrzestepnymRoku()
        {
            try
            {
                Data data = new Data(29, 2, 2020);
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
