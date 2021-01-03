using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t13
{
    public class Astra : Auto
    {
        public override string ToString()
        {
            if (Model == default || Weight == default || MaxSpeed == default)
            {
                return base.ToString();
            }
            return "Это Астра в стандартной комплектации!";
        }

        public Astra(string model, int maxSpeed, double weight)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            Weight = weight;
        }
    }
}
