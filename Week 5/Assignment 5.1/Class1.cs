using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._1
{
    enum Department
    {
        IT,
        Finance,
        HR,
        Marketing,
        Production,
        Sales,

    }
    class Employee
    {
        public int EmpID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Department Dept { get; set; }
        public DateTime Dob { get; set; }
        public int Age { get; set; }
        public string Addy { get; set; }
        public string Phone { get; set; }
    }

    interface ICalculator
    {
        decimal add(decimal num1, decimal num2);
        decimal substract(decimal num1, decimal num2);
        decimal multiply(decimal num1, decimal num2);
        decimal divide(decimal num1, decimal num2);

    }
    public class Calculator : ICalculator
    {
        public decimal add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public decimal substract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public decimal multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public decimal divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
