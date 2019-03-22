using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace Training
{
    public class Program
    {
        public static void Main(string[] args)
        {


           //// Liczba liczba =  new Liczba( 5);

           // liczba.tablicaLiczbDziesietnych = new[] {5.5, 2, 13,};


           // liczba.WypiszlTablice();

           // Console.WriteLine("Silnia: " + liczba.Silnia(5));



            Data data = new Data(29, 12, 2019);
            

            Console.WriteLine(data.ToStringDDMMRR());
            data.DodajDzien();
            Console.WriteLine(data.ToStringDDMMRR());
            data.DodajRok();
            Console.WriteLine(data.ToStringDDMMRR());
            data.DodajDzien();
            Console.WriteLine(data.ToStringDDMMRR());
            data.DodajDzien();
            Console.WriteLine(data.ToStringDDMMRR());
            data.DodajRok();
            Console.WriteLine(data.ToStringDDMMRR());
            data.OdejmnijDzien();
            Console.WriteLine(data.ToStringDDMMRR());



            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
