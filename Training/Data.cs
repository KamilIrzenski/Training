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
        private FormatDaty formatDate = FormatDaty.DDMMYYYY;
        private int day = 0;
        private int month = 0;
        private int year = 0;
        private string format = String.Empty;
        private string statement = "Niepoprawna Data";

        public Data()
        {
            formatDate = FormatDaty.YYYYMMDD;
            day = 31;
            month = 12;
            year = 1899;
        }

        public Data(int dayParametr, int monthParametr, int yearParametr)
        {
            day = dayParametr;
            month = monthParametr;
            year = yearParametr;
            ChechCorrectDate();
        }

        public Data(int dayParametr, int monthParametr, int yearParametr, FormatDaty formatDate) : this(
            dayParametr, monthParametr, yearParametr)
        {
            this.formatDate = formatDate;
        }

        public void AddDay()
        {
            day++;
            if ((month == 10 || month == 8 || month == 7 || month == 5 || month == 3 ||
                month == 1) && day == 31 || (month == 11 || month == 9 || month == 6 || month == 4) && day == 30 || (month == 2 && year % 4 == 0) && day == 29 || month == 2 && day == 28)
            {
                AddMonth();
                day = 1;
            }

            else if (month == 12 && day > 31)
            {
                AddYear();
                day = 1;
                month = 1;
            }
        }

        public void SubtractDay()
        {
            day--;
            if (day < 1)
            {
                SubtractMonth();
                if (month == 1 && day < 1)
                {
                    SubtractYear();
                    day = 31;
                    month = 12;
                }

                if (month == 12 || month == 10 || month == 8 || month == 7 || month == 5 || month == 3 ||
                    month == 1)
                {
                    day = 31;
                }
                else if (month == 11 || month == 9 || month == 6 || month == 4)
                {
                    day = 30;
                }
                else if (month == 2 && year % 4 == 0)
                {
                    day = 29;
                }
                else if (month == 2)
                {
                    day = 28;
                }
            }
        }

        public string DataString()
        {
            //  return day.ToString() + "-" + month.ToString() + "-" + year.ToString();
            return string.Format("{0}-{1}-{2}", year, month, day);
        }

        private string ToStringMMDDRRRR()
        {
            return string.Format("{0:00}{1:00}{2}", month, day, year);
        }

        private string ToStringDDMMRR()
        {
            return string.Format("{0:00}{1:00}{2}", day, month, year);
        }

        private string ToStringRRMMDD()
        {
            string miesiacFormat = string.Empty;
            string dzienFormat = string.Empty;
            if (month <= 9)
            {
                miesiacFormat = "0";
            }
            if (day <= 9)
            {
                dzienFormat = "0";
            }

            return string.Format("{0}{1}{2}", year, miesiacFormat + month, dzienFormat + day);
        }

        public void AddMonth()
        {
            month++;
            if (month > 12)
            {
                AddYear();
                month = 1;
            }
            else if ((month == 11 || month == 9 || month == 6 || month == 4) && day == 31)
            {
                day = 30;
            }
            else if (month == 2 && year % 4 == 0)
            {
                day = 29;
            }
            else if (month == 2)
            {
                day = 28;
            }
        }

        public void SubtractMonth()
        {
            month--;
            if (month < 1)
            {
                SubtractYear();
                month = 12;
            }

            if (month == 11 || month == 9 || month == 6 || month == 4)
            {
                day = 30;
            }
            else if (month == 2 && year % 4 == 0)
            {
                day = 29;
            }
            else if (month == 2)
            {
                day = 28;
            }
        }
        public string ToStringInWords()
        {
            string miesiacSlownie = string.Empty;

            if (month == 1)
            {
                miesiacSlownie = "Styczen";

            }
            else if (month == 2)
            {
                miesiacSlownie = "Luty";
            }
            else if (month == 3)
            {
                miesiacSlownie = "Marzec";
            }
            else if (month == 4)
            {
                miesiacSlownie = "Kwiecien";
            }
            else if (month == 5)
            {
                miesiacSlownie = "Maj";
            }
            else if (month == 6)
            {
                miesiacSlownie = "Czerwiec";
            }
            else if (month == 7)
            {
                miesiacSlownie = "Lipiec";
            }
            else if (month == 8)
            {
                miesiacSlownie = "Sierpien";
            }
            else if (month == 9)
            {
                miesiacSlownie = "Wrzesien";
            }
            else if (month == 10)
            {
                miesiacSlownie = "Pazdziernik";
            }
            else if (month == 11)
            {
                miesiacSlownie = "Listopad";
            }
            else if (month == 12)
            {
                miesiacSlownie = "Grudzien";
            }
            return string.Format("{0} {1} {2} ", day, miesiacSlownie, year);
        }
        public void AddYear()
        {
            year++;
        }
        public void SubtractYear()
        {
            year--;
        }
        public void SetDate(int dzienParametr, int miesiacParametr, int rokParametr)
        {
            day = dzienParametr;
            month = miesiacParametr;
            year = rokParametr;
            ChechCorrectDate();
        }
        public override string ToString()
        {

            if (formatDate == FormatDaty.DDMMYYYY)
            {
                return ToStringDDMMRR();
            }

            if (formatDate == FormatDaty.MMDDYYYY)
            {
                return ToStringMMDDRRRR();
            }

            string data = ToStringRRMMDD();
            return data;
        }

        public void ChechCorrectDate()
        {
            if (day < 1)
            {
                throw new Exception(statement);
            }

            else if (month < 1 || month > 12)
            {
                throw new Exception(statement);
            }

            else if (day > 31)
            {
                throw new Exception(statement);
            }
            else if ((month == 2 && year % 4 == 0) && day > 29)
            {
                throw new Exception(statement);
            }
            else if ((month == 2 && year % 4 != 0) && day > 28)
            {
                throw new Exception(statement);
            }
            else if ((month == 11 || month == 9 || month == 6 || month == 4) && day > 30)
            {
                throw new Exception(statement);
            }
        }
    }

}
