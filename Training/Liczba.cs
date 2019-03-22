using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Liczba
    {



        public double[] tablicaLiczbDziesietnych;


        public Liczba(string parametrTablicy)
        {

        }

        public void WypiszlTablice()
        {
            foreach (var elementy in tablicaLiczbDziesietnych)
            {
                Console.WriteLine(elementy);
            }
        }

        public int Silnia(int liczbaP)
        {
            int wynik = 1;

            for (int i = 1; i <= liczbaP; i++)
            {
                wynik = wynik * i;
            }

            return wynik;
        }

        public void Mnozenie(int mnozna)
        {
        //  int wynik = 0;
            

        }



    }
}
