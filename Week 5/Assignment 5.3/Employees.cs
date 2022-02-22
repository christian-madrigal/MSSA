using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_5._3
{
    [Serializable]
    
    enum Position
    {

        FullTime,
        PartTime,
        Salary,
    }

    [Serializable]

    class Employees
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public Position Pos { get; set; }
    }
}
