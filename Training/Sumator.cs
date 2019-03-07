using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Sumator
    {


        public Sumator()
        {

        }

        public int[] tablica = new int[7]
        {
            5, 4, 9, 3, 2, 6, 8,
        };




        public int Suma()
        {
            int wynik = 0;
            return wynik = wynik + tablica.Sum();
        }

        public int SumaPodzielPrzez3()
        {
            int elementyPodzielnePrzez3 = 0;

            //int wynik = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] % 3 == 0)
                {
                    elementyPodzielnePrzez3 = elementyPodzielnePrzez3 + tablica[i];
                }
            }

            return elementyPodzielnePrzez3;
        }

        public int IleElementow()
        {
            return tablica.Count();
        }


        public void WypiszElementy()
        {
            //nie wiem jak tu zrobic zeby return zwracal cala tablice i pozniej to w mainie wywolac 
            foreach (var elementyTablicy in tablica)
            {

                Console.WriteLine(elementyTablicy);

            }
        }


        public int NajmniejszyNajwiekszy()
        {
          
            int najmniejszyElement = tablica[0];
            int najwiekszyElement = tablica[0];

            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length; j++)
                {
                    if (najwiekszyElement < tablica[j])
                    {
                        najwiekszyElement = tablica[j];
                    }
                }

                if (najmniejszyElement > tablica[i])
                {
                    najmniejszyElement = tablica[i];
                }
            }
            //nie da sie podac dwie wartosci zeby zwrocila ?? 
            return najwiekszyElement;
        }
        public int NajmniejszyNajwiekszy(out int lowIndex,out int highIndex )
        {
            highIndex = 0;
            lowIndex = 0; 
            
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j <= tablica.Length; j++)
                {
                    if (highIndex < tablica[j])
                    {
                        highIndex = tablica[j];
                    }
                }

                if (lowIndex >= tablica[i])
                {
                    lowIndex = tablica[i];
                }
            }
            //nie da sie podac dwie wartosci zeby zwrocila ?? 
            return lowIndex && highIndex;
        }
    }

  
}
