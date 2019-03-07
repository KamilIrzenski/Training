using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Licz : Program
    {

        public Licz()
        {

        }
        public Licz(int parametrWartosc)
        {
            wartosc = parametrWartosc;
        }


        private int wartosc = 5;

        void stanObiektu()
        {
            Console.WriteLine(wartosc);
        }

        

        public int dodaj(int parametr1)
        { 

            return parametr1 = parametr1 + wartosc;
        }

        public int odejmnij(int parametr1)
        { 

            return parametr1 = parametr1 - wartosc;

        }



    }
}
