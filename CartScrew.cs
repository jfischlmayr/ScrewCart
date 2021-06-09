using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrewCart
{
    public class CartScrew
    {
        public string Type { get; set; }
        public double Price { get; set; }
        public double Kg { get; set; }
        public int Amount { get; set; }
        public string DisplayString { get => $"{Amount}x {Type} Weight: {Kg}kg Cost: {Price}"; }

        public CartScrew()
        {

        }

        public CartScrew(string type)
        {
            Type = type;
        }
    }
}
