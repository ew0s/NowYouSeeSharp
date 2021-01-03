using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t28
{
    public class Hedgehog
    {
        public int Lenght { get; set; }
        public int Weight { get; set; }


        public static explicit operator Snake(Hedgehog hedgehog)
        {
            return new Snake()
            {
                Lenght = hedgehog.Lenght <= 0 ? Int32.MaxValue : hedgehog.Lenght > 3 ? 3 : hedgehog.Lenght,
                Weight = hedgehog.Weight <= 0 ? Int32.MaxValue : hedgehog.Weight > 5 ? 5 : hedgehog.Weight
            };
        }
    }
}
