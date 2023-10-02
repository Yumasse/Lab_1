using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Address
    {
        public int index { get; set; } = 02222;
        public string country { get; set; } = "Ukraine";
        public string sity { get; set; } = "Kyiv";
        public string street { get; set; } = "Teodora Draizera";
        public int house { get; set; } = 30;
        public int apartament { get; set; } = 58;

        public void Print()

        {
            Console.WriteLine(index + country + sity + street + house + apartament);

        }
    }
}
