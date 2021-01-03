using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t13
{
    public class Auto
    {
        protected string Model { get; set; }
        protected int MaxSpeed { get; set; }
        protected double Weight { get; set; }

        public void DescribeCar()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "Очень крутая машинка, но характеристики я вам не скажу...";

        }
    }
}
