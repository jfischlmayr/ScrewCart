using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrewCart
{
    public class Screw
    {
        public string Type { get; set; }
        public double PricePer100 { get; set; }
        public double KgPer100 { get; set; }
        public double TotalPrice { get; set; }
        public double TotalKg { get; set; }
        public int Amount { get; set; }

        public Screw()
        {

        }

        public Screw(string type, double pricePer100, double kgPer100)
        {
            Type = type;
            PricePer100 = pricePer100;
            KgPer100 = kgPer100;
        }
    }
}
