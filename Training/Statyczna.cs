using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public  class Statyczna
    {

        public int i;
        public static int liczba;

        public Statyczna(int parametr)
        {
            i = parametr;
            Zwieksz();
        }

       public static int Zwieksz()
        {
            
            liczba++;

            return liczba;
        }

    }
}
