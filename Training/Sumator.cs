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

            foreach (var elementyTablicy in tablica)
            {

                Console.WriteLine(elementyTablicy);

            }


        }

        public void NajmniejszyNajwiekszy(int lowIndex,int highIndex )
        {
       
            
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i >= lowIndex && i<= highIndex)
                {
                    Console.WriteLine(tablica[i]);
                }
            }
          
        }
    }

  
}
