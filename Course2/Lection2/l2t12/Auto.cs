using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t12
{
    public class Auto
    {
        protected string Model { get; set; }
        protected int MaxSpeed { get; set; }
        protected double Weight { get; set; }

        public Auto(string model, int maxSpeed, double weight)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            Weight = weight;
        }
    }
}
