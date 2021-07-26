using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        int day;
        int month;
        int year;

        public Date (int day, int month, int year) 
        {
            if (day <= 31)
            {
              this.day = day;
            }
            else
            {
              this.day = 0;
            }

            if (year >= 1900 || year <= 2050)
            {
              this.year = year;
            }
            else
            { 
              this.year = 0; 
            }

            if (month <= 12)
            {
              this.month = month;
            }
            else
            { 
              this.month = 0;
            }
        }

        public int SetDay(int day) 
        {
            this.day = day;
            return day;
        }

        public int SetMonth(int month)
        {
            this.month = month;
            return month;
        }

        public int SetYear(int year)
        {
            this.year = year;
            return year;
        }

        public int GetYear()
        {
            return year;
        }

        public int GetMonth()
        {
            return month;
        }

        public int GetDay()
        {
            return day;
        }

        public void DisplayDate() 
        {
            Console.WriteLine(day + "/" + month + "/" + year);
        }
    }
}
