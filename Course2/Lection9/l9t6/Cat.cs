﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t6
{
    [Serializable]
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Я Котик по имени {Name} и мне {Age} лет!";
        }
    }
}