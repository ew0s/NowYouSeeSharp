﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t13
{
    public class Vectra : Auto
    {
        public override string ToString()
        {
            if (Model == default || Weight == default || MaxSpeed == default)
            {
                return base.ToString();
            }
            return "Это Вектра в стандартной комплектации!";
        }

        public Vectra(string model, int maxSpeed, double weight)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            Weight = weight;
        }
    }
}