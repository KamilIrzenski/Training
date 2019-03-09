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
            Statyczna sta = new Statyczna(5);
            Data data = new Data(15, 2, 2019);

            
            Console.WriteLine($"Wyswietl date: {data.dzien}.{data.miesiac}.{data.rok}r");
            Console.WriteLine("dzien minus jeden " + data.OdejmnijDzien());
            Console.WriteLine("dzien plus jeden " + data.DodajDzien());
            Console.WriteLine("----------------------");

            
            sum.WypiszElementy();

            Console.WriteLine("---------------");

            sum.NajmniejszyNajwiekszy(3, 6);
            Console.WriteLine("------------------------");

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
