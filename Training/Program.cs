using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace Training
{
   public class Program
    {
       public static void Main(string[] args)
        {

            Licz licz = new Licz(50);
            Licz licz2 = new Licz();
            Sumator sum = new Sumator();
         

            Console.WriteLine(sum.NajmniejszyNajwiekszy());

            Console.WriteLine(sum.IleElementow() + " elemtow jest w tablicy");

            Console.WriteLine("Suma liczb podzielnych przez 3: " + sum.SumaPodzielPrzez3());

            Console.WriteLine("Suma liczb z tablicy: " + sum.Suma());

            Console.WriteLine("Suma liczb parametr z konstruktora: " + licz.dodaj(4));

            Console.WriteLine("Metoda odejmnij: " + licz2.odejmnij(10));

            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
