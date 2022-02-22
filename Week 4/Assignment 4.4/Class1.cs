using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._4
{
    enum Bean
    {
        Columbian,
        Etheopian,
        Arabic,
        Peru,
    }
    enum Dairy
    {
        WholeMilk,
        ReducedMilk,
        NonFatMilk,
        SoyMilk,
        AlmondMilk,
        OatMilk,
        NoMilk,
    }
    public abstract class Beverages
    {
        public abstract int OrderID { get; set; }
        public abstract string Name { get; set; }
        public abstract string Size { get; set; }
    }

    class Coffee : Beverages
    {
        override public int OrderID { get; set; }
        override public string Name { get; set; }
        override public string Size { get; set; }
        public string Temp { get; set; }
        public decimal Price { get; set; }
        public Bean Beans { get; set; }
        public Dairy Milk { get; set; }

    
    }
}
