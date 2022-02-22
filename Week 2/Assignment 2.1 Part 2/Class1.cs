using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1_Part_2
{
    public class Automotive
    {
        public string AutomotiveType { get; set; }
    }

    public class Car: Automotive
    {
        public string CarMake { get; set; }

        public string BodyType { get; set; }
    }

    public class Honda:Car
    {
        public string Color { get; set; }

        public string HorsePower { get; set; }
    }

    public class Cheverolete:Car
    {
        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
}
