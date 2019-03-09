using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Data
    {

        public Data(int dzienParametr, int miesiacParametr, int rokParametr)
        {
            dzien = dzienParametr;
            miesiac = miesiacParametr;
            rok = rokParametr;


        }


        public int dzien { get; set; }
        public int miesiac { get; set; }
        public int rok { get; set; }


        public int DodajDzien()
        {
          
           dzien++;
           
            return dzien;
        }

        public int OdejmnijDzien()
        {

           dzien--;

            return dzien;
        }


    }
}
