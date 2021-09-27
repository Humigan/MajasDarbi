using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.exe5.Test
{
    public class ClassesAndObjects_exe5
    {
        int day;
        int month;
        int year;

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
    }
}