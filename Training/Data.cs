using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Data
    {
        private int dzien = 0;
        private int miesiac = 0;
        private int rok = 0;

        public Data()
        {
            dzien = 31;
            miesiac = 12;
            rok = 1899;
        }


        public Data(int dzienParametr, int miesiacParametr, int rokParametr)
        {
            dzien = dzienParametr;
            miesiac = miesiacParametr;
            rok = rokParametr;

        }


        public void DodajDzien()
        {
            dzien++;

            if (miesiac == 1 && dzien > 31)
            {
                DodajMiesiac();
                dzien = 1;
            }
            else if (miesiac == 2 && dzien >28)
            {
                DodajMiesiac();
                dzien = 1;
            }
            else if (miesiac == 3 && dzien > 31)
            {
                DodajMiesiac();
                dzien = 1;
            }
            else if (miesiac == 4 && dzien > 30)
            {
                DodajMiesiac();
                dzien = 1;
            }
            else if (miesiac == 5 && dzien > 31)
            {
                DodajMiesiac();
                dzien = 1;
            }

            else if (miesiac == 6 && dzien > 30)
            {
                DodajMiesiac();
                dzien = 1;
            }

            else if (miesiac == 7 && dzien > 31)
            {
                DodajMiesiac();
                dzien = 1;
            }

            else if (miesiac == 8 && dzien > 31)
            {
                DodajMiesiac();
                dzien = 1;
            }

            else if (miesiac == 9 && dzien > 30)
            {
                DodajMiesiac();
                dzien = 1;
            }

            else if (miesiac == 10 && dzien > 31)
            {
                DodajMiesiac();
                dzien = 1;
            }
            else if (miesiac == 11 && dzien > 30)
            {
                DodajMiesiac();
                dzien = 1;
            }

            else if (miesiac == 12 && dzien > 31)
            {
                DodajRok();
                dzien = 1;
                miesiac = 1;
            }

            
        }

        public void OdejmnijDzien()
        {
            dzien--;
            if (dzien < 1)
            {
                OdejmnijMiesiac();
                if (miesiac == 1 && dzien < 1 )
                {
                    OdejmnijRok();
                    dzien = 31;
                    miesiac = 12;
                }
                if (miesiac == 12 || miesiac == 10 || miesiac == 8 || miesiac == 7 || miesiac == 5 || miesiac == 3 || miesiac == 1)
                {
                    dzien = 31;
                }
                else if (miesiac == 11 || miesiac == 9 || miesiac == 6 || miesiac == 4)
                {
                    dzien = 30;
                }
                else if (miesiac == 2)
                {
                    dzien = 28;
                }
            }

        }

        public string DataString()
        {
            //  return dzien.ToString() + "-" + miesiac.ToString() + "-" + rok.ToString();

            return string.Format("{0}-{1}-{2}", rok, miesiac, dzien);
        }

        public string ToStringDDMMRR()
        {
            return string.Format("{0}-{1}-{2}", dzien, miesiac, rok);
        }

        public string ToStringRRMMDD()
        {
            return string.Format("{0}{1}{2}", rok, miesiac, dzien);
        }

        public void DodajMiesiac()
        {
            miesiac++;
            if (miesiac > 12)
            {
                DodajRok();
                // dzien = 1;
                miesiac = 1;
                if (miesiac == 12 || miesiac == 10 || miesiac == 8 || miesiac == 7 || miesiac == 5 || miesiac == 3 || miesiac == 1)
                {
                    dzien = 31;
                }
                else if (miesiac == 11 || miesiac == 9 || miesiac == 6 || miesiac == 4)
                {
                    dzien = 30;
                }
                else if (miesiac == 2)
                {
                    dzien = 28;
                }
            }


        }

        public void OdejmnijMiesiac()
        {
            miesiac--;
            if (miesiac < 1)
            {
                OdejmnijRok();
                //  dzien = 1;
                miesiac = 12;
                if (miesiac == 12 || miesiac == 10 || miesiac == 8 || miesiac == 7 || miesiac == 5 || miesiac == 3 || miesiac == 1)
                {
                    dzien = 31;
                }
                else if (miesiac == 11 || miesiac == 9 || miesiac == 6 || miesiac == 4)
                {
                    dzien = 30;
                }
                else if (miesiac == 2)
                {
                    dzien = 28;
                }

            }

        }

        public string ToStringSlownie()
        {
            string miesiacSlownie = string.Empty;


            if (miesiac == 1)
            {
                miesiacSlownie = "Styczen";

            }
            else if (miesiac == 2)
            {
                miesiacSlownie = "Luty";
            }

            else if (miesiac == 3)
            {
                miesiacSlownie = "Marzec";
            }
            else if (miesiac == 4)
            {
                miesiacSlownie = "Kwiecien";
            }
            else if (miesiac == 5)
            {
                miesiacSlownie = "Maj";
            }
            else if (miesiac == 6)
            {
                miesiacSlownie = "Czerwiec";
            }
            else if (miesiac == 7)
            {
                miesiacSlownie = "Lipiec";
            }
            else if (miesiac == 8)
            {
                miesiacSlownie = "Sierpien";
            }
            else if (miesiac == 9)
            {
                miesiacSlownie = "Wrzesien";
            }
            else if (miesiac == 10)
            {
                miesiacSlownie = "Pazdziernik";
            }
            else if (miesiac == 11)
            {
                miesiacSlownie = "Listopad";
            }
            else if (miesiac == 12)
            {
                miesiacSlownie = "Grudzien";
            }


            return string.Format("{0} {1} {2} ", dzien, miesiacSlownie, rok);

        }

        public void DodajRok()
        {
            rok++;

        }

        public void OdejmnijRok()
        {
            rok--;
        }


    }


}
