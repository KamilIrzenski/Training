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
        public void powinienZwrocicZeDatySaSobieRownePrzyPomocyOperatora()
        {
            Data dataPierwszegoLotuWKosmos = new Data(4, 10, 1957);
            Data dataUrodzeniaMarilynNorry = new Data(4, 10, 1957);

            bool saRowne = dataPierwszegoLotuWKosmos == dataUrodzeniaMarilynNorry;

            Assert.IsTrue(saRowne);
        }

        [TestMethod]
        public void powinienZwrocicZeDataLotuCzlowiekaWKosmosJestWiekszaOdDatyWystrzeleniaPierwszegoSatelity()
        {
            Data dataPierwszegoLotuSatelityWKosmos = new Data(4, 10, 1957);
            Data dataPierwszegoLotuCzlowiekaWKosmos = new Data(12, 4, 1961);

            bool dataLotuCzlowiekaJestWieksza = false;
            // dataLotuCzlowiekaJestWieksza = dataPierwszegoLotuCzlowiekaWKosmos > dataPierwszegoLotuSatelityWKosmos;

            Assert.IsTrue(dataLotuCzlowiekaJestWieksza);
        }

        [TestMethod]
        public void powinienZwrocicRozniceWDniachPomiedzyDwiemaDatami()
        {
            Data dataSiedemnastyKwietnia = new Data(17, 4, 2019);
            Data dataDziesiatyKwietnia = new Data(10, 4, 2019);

            int roznicaDni = 0;
            // roznicaDni = dataSiedemnastyKwietnia - dataDziesiatyKwietnia;

            Assert.AreEqual(7, roznicaDni);
        }

        [TestMethod]
        public void powinienPodczasOperacjiPrzepisaniaWykonacKopieDatyZamiastPrzepisacReferencje()
        {
            // Data dataSiedemnastyKwietnia = new Data(17, 4, 2019);
            // Data dataDziesiatyKwietnia = new Data(10, 4, 2019);
            // 
            // dataSiedemnastyKwietnia = dataDziesiatyKwietnia;
            Assert.Fail();
        }
    }
}
