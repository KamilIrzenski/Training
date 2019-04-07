using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public enum FormatDaty
    {
        YYYYMMDD,
        DDMMYYYY,
        MMDDYYYY,
    }
    public class Data
    {
        private FormatDaty enumDaty = FormatDaty.DDMMYYYY;

        private int dzien = 0;
        private int miesiac = 0;
        private int rok = 0;
        private string format = String.Empty;
        private string komunikat = "Niepoprawna Data";


        public Data()
        {

            enumDaty = FormatDaty.YYYYMMDD;
            dzien = 31;
            miesiac = 12;
            rok = 1899;

        }
        public Data(int dzienParametr, int miesiacParametr, int rokParametr)
        {
            dzien = dzienParametr;
            miesiac = miesiacParametr;
            rok = rokParametr;

            SprawdzPoprawnoscDaty();
        }

        public Data(int dzienParametr, int miesiacParametr, int rokParametr, FormatDaty formatDaty) : this(dzienParametr, miesiacParametr, rokParametr)
        {
            // format = formatDaty;

            enumDaty = formatDaty;

        }
        public void DodajDzien()
        {
            dzien++;
            if (miesiac == 1 && dzien > 31 
             || miesiac == 2 && dzien > 28 
             || miesiac == 3 && dzien > 31 
             || miesiac == 4 && dzien > 30 
             || miesiac == 5 && dzien > 31 
             || miesiac == 6 && dzien > 30 
             || miesiac == 7 && dzien > 31 
             || miesiac == 8 && dzien > 31 
             || miesiac == 9 && dzien > 30 
             || miesiac == 10 && dzien > 31 
             || miesiac == 11 && dzien > 30)
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
                if (miesiac == 1 && dzien < 1)
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
                else if (miesiac == 2 && rok % 4 == 0)
                {
                    dzien = 29;
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

        private string ToStringMMDDRRRR()
        {
            return string.Format("{0:00}{1:00}{2}", miesiac, dzien, rok);
        }

        private string ToStringDDMMRR()
        {
            return string.Format("{0:00}{1:00}{2}", dzien, miesiac, rok);
        }
        private string ToStringRRMMDD()
        {
            string miesiacFormat = string.Empty;
            string dzienFormat = string.Empty;
            if (miesiac <= 9)
            {
                miesiacFormat = "0";
            }

            if (dzien <= 9)
            {
                dzienFormat = "0";
            }

            return string.Format("{0}{1}{2}", rok, miesiacFormat + miesiac, dzienFormat + dzien);
        }
        public void DodajMiesiac()
        {
            miesiac++;
            if (miesiac > 12)
            {
                DodajRok();
                miesiac = 1;
            }
            else if ((miesiac == 11 || miesiac == 9 || miesiac == 6 || miesiac == 4) && dzien == 31)
            {
                dzien = 30;
            }
            else if (miesiac == 2 && rok % 4 == 0)
            {
                dzien = 29;
            }
            else if (miesiac == 2)
            {
                dzien = 28;
            }
        }

        public void OdejmnijMiesiac()
        {

            miesiac--;
            if (miesiac < 1)
            {
                OdejmnijRok();
                miesiac = 12;
            }

            if (miesiac == 11 || miesiac == 9 || miesiac == 6 || miesiac == 4)
            {
                dzien = 30;
            }
            else if (miesiac == 2 && rok % 4 == 0)
            {
                dzien = 29;
            }
            else if (miesiac == 2)
            {
                dzien = 28;
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

        public void UstawDate(int dzienParametr, int miesiacParametr, int rokParametr)
        {
            dzien = dzienParametr;
            miesiac = miesiacParametr;
            rok = rokParametr;

            SprawdzPoprawnoscDaty();

        }

        public override string ToString()
        {

            if (enumDaty == FormatDaty.DDMMYYYY)
            {
                return ToStringDDMMRR();
            }

            if (enumDaty == FormatDaty.MMDDYYYY)
            {
                return ToStringMMDDRRRR();
            }
            //if (enumDaty == FormatDaty.YYYYMMDD)
            //{
            //    return ToStringRRMMDD();
            //}
            string data = ToStringRRMMDD();
            return data;
        }

        public void SprawdzPoprawnoscDaty()
        {
            if (dzien < 1)
            {
                throw new Exception(komunikat);
            }

            else if (miesiac < 1 || miesiac > 12)
            {
                throw new Exception(komunikat);
            }

            else if (dzien > 31)
            {
                throw new Exception(komunikat);
            }
            else if ((miesiac == 2 && rok % 4 == 0) && dzien > 29)
            {
                throw new Exception(komunikat);
            }
            else if ((miesiac == 2 && rok % 4 != 0) && dzien > 28)
            {
                throw new Exception(komunikat);
            }
            else if ((miesiac == 11 || miesiac == 9 || miesiac == 6 || miesiac == 4) && dzien > 30)
            {
                throw new Exception(komunikat);
            }
        }
    }//TODO: validacje na dzien i miesiac 

}
