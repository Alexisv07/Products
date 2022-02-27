using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
   
        public class Date
        {
            //private string Nombres;
            //private string Description;
            //private int ID;
            //private float;
            private int _year;
            private int _month;
            private int _day;

            public Date()
            {
            }

            public Date(int year, int month, int day)
            {
                _year = year;
                _month = month;
                _day =  day;
            }

        public override string ToString()
        {
            return $"{_year}/{_month}/{_day}";
        }

    }
    
}
