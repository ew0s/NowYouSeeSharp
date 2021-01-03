using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t13
{
    public class Cat
    {
        private double speed;
        private decimal moneyCount;
        private bool isSleep;
        private short weight;
        private int age;
        private string name;
        public string Name {
            get
            {
                return name;
            }
            private set { name = value; }

        }

        public short Weight {
            get
            {
                return Convert.ToInt16(weight * weight);
            }
            private set { weight = value; } }

        public int Age
        {
            get
            {
                return Convert.ToInt16(age * age);
            }
            private set { age = value; }
        }

        public bool IsSleep
        {
            get
            {
                return !isSleep;
            }
            private set { isSleep = value; }
        }

        public double Speed
        {
            get
            {
                return Convert.ToInt32(speed);
            }
            private set { speed = value; }
        }

        public decimal MoneyCount
        {
            get
            {
                return Convert.ToInt32(moneyCount);
            }
            private set { moneyCount = value; }
        }

        public Cat(string name, short weight, int age )
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            Speed = this.weight * this.age;
            MoneyCount = this.age < 10 ? 1000 : default;
        }

        public override string ToString()
        {
            return
                $"Привет! Я котик по имени {name}, мне {age} лет и я люблю спать. Это плохо сказывается на моём весе и состоянии счёта =(";
        }
    }
}
