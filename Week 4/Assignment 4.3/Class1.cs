using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._3
{
    enum Grades
    {
        A,
        B,
        C,
        D,
        F
    }
    enum MonthofAdmission
    {
        Jan,
        Feb,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    struct Students
    {
        public int Stuid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public Grades Grade { get; set; }
        public MonthofAdmission Month { get; set; }


    }
}
