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
            int jakastamliczba = 7;

            Data data = new Data(1, 10, 2019);
            Console.WriteLine(data);
            Console.WriteLine(jakastamliczba);

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
