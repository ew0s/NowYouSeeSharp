using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t21
{
    public class Duck : Bird
    {
        private int currentBreadCount;
        internal string currentLake;
        private bool haveCuteLittleDucks;
        private bool isLittle;
        private bool isHungry;

        private List<Duck> allLittleDucks;
        private List<Duck> AllLittleDucks
        {
            get
            {
                return allLittleDucks;
            }
            set
            {
                int a = 0;
                foreach (var item in value)
                {
                    if (item.isLittle)
                    {
                        a++;
                    }
                }
                if (a == value.Count)
                {
                    allLittleDucks = value;
                }
            }
        }

        public Duck(string name, bool isLittle)
        {
            Name = name;
            currentBreadCount = 0;
            currentLake = "SunnyLake";
            haveCuteLittleDucks = false;
            Weight = 100;
            Description = "Уточка по имени " + name;
            this.isLittle = isLittle;
            isHungry = true;
            AllLittleDucks = new List<Duck>();
        }

        internal void Eat(int breadCount)
        {
            currentBreadCount += breadCount;
            if (currentBreadCount > 100)
            {
                this.isHungry = false;
                this.allLittleDucks.AddRange(CreateCuteLittleDucks());
            }
            else
            {
                this.currentBreadCount = 0;
                this.currentLake = "Some another Lake";
            }
            this.Weight += breadCount;
        }

        private List<Duck> CreateCuteLittleDucks()
        {
            return new List<Duck>() { new Duck("Уточка", true), new Duck("Утёнок", true) };
        }
    }
}
