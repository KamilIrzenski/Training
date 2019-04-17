using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training;

namespace Tests
{
    [TestClass]
    public class DateClassCompareTests
    {
        [TestMethod]
        public void powinienZwrocicZeDatySaSobieRownePrzyPomocyEquals()
        {
            Data dataPierwszegoLotuWKosmos = new Data(4, 10, 1957);
            Data dataUrodzeniaMarilynNorry = new Data(4, 10, 1957);

            bool saRowne = dataPierwszegoLotuWKosmos.Equals(dataUrodzeniaMarilynNorry);

            Assert.IsTrue(saRowne);
        }

        [TestMethod]
        public void powinienZwrocicZeDatyNieSaSobieRownePrzyPomocyEquals()
        {
            Data dataPierwszegoLotuWKosmos = new Data(4, 10, 1957);
            Data dataUrodzeniaMarilynNorry = new Data(5, 10, 1957);

            bool saRowne = dataPierwszegoLotuWKosmos.Equals(dataUrodzeniaMarilynNorry);

            Assert.IsFalse(saRowne);
        }

        [TestMethod]
        public void powinienZwrocicZeDatySaSobieRownePrzyPomocyOperatora()
        {
            Data dataPierwszegoLotuWKosmos = new Data(4, 10, 1957);
            Data dataUrodzeniaMarilynNorry = new Data(4, 10, 1957);

            bool saRowne = dataPierwszegoLotuWKosmos == dataUrodzeniaMarilynNorry;

            Assert.IsTrue(saRowne);
        }

        [TestMethod]
        public void powinienZwrocicZeDatyNieSaSobieRownePrzyPomocyOperatora()
        {
            Data dataPierwszegoLotuWKosmos = new Data(4, 10, 1957);
            Data dataUrodzeniaMarilynNorry = new Data(5, 10, 1957);

            bool saRowne = dataPierwszegoLotuWKosmos == dataUrodzeniaMarilynNorry;

            Assert.IsFalse(saRowne);
        }

        [TestMethod]
        public void powinienZwrocicZeDataLotuCzlowiekaWKosmosJestWiekszaOdDatyWystrzeleniaPierwszegoSatelity()
        {
            Data dataPierwszegoLotuSatelityWKosmos = new Data(4, 10, 1957);
            Data dataPierwszegoLotuCzlowiekaWKosmos = new Data(12, 4, 1961);
        
            bool dataLotuCzlowiekaJestWieksza = false;
            dataLotuCzlowiekaJestWieksza = dataPierwszegoLotuCzlowiekaWKosmos > dataPierwszegoLotuSatelityWKosmos;
        
            Assert.IsTrue(dataLotuCzlowiekaJestWieksza);
        }


        [TestMethod]
        public void powinienData()
        {
            Data data1 = new Data(4, 10, 1957);
            Data data2 = new Data(12, 4, 2019);

            bool data1Wieksza = false;
            data1Wieksza = data1 > data2;

            Assert.IsFalse(data1Wieksza);
        }


        [TestMethod]
        public void powinienZwrocicZeDataLotuPierwszegoSatelityNieJestMniejszaOdPierwszegoLotuWKosmos()
        {
            Data dataPierwszegoLotuSatelityWKosmos = new Data(4, 10, 1957);
            Data dataPierwszegoLotuCzlowiekaWKosmos = new Data(12, 4, 1961);

            bool dataLotuCzlowiekaJestWieksza = false;
            dataLotuCzlowiekaJestWieksza = dataPierwszegoLotuCzlowiekaWKosmos < dataPierwszegoLotuSatelityWKosmos;

            Assert.IsFalse(dataLotuCzlowiekaJestWieksza);
        }

        // [TestMethod]
        // public void powinienZwrocicRozniceWDniachPomiedzyDwiemaDatami()
        // {
        //     Data dataSiedemnastyKwietnia = new Data(17, 4, 2019);
        //     Data dataDziesiatyKwietnia = new Data(10, 4, 2019);
        // 
        //     int roznicaDni = 0;
        //     roznicaDni = dataSiedemnastyKwietnia - dataDziesiatyKwietnia;
        // 
        //     Assert.AreEqual(7, roznicaDni);
        // }
        // 
        // [TestMethod]
        // public void powinienPodczasOperacjiPrzepisaniaWykonacKopieDatyZamiastPrzepisacReferencje()
        // {
        //     Data dataSiedemnastyKwietnia = new Data(17, 4, 2019);
        //     Data dataDziesiatyKwietnia = new Data(10, 4, 2019);
        //     
        //     dataSiedemnastyKwietnia = dataDziesiatyKwietnia;
        //     Assert.Fail();
        // }
    }
}
