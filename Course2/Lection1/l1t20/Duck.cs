using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t20
{
    public class Duck : Bird
    {
        public int currentBreadCount;
        public string currentLake;
        public bool haveCuteLittleDucks;
        public bool isLittle;
        public bool IsHungry;

        private List<Duck> allLittleDucks;
        public List<Duck> AllLittleDucks
        {
            get
            {
                return allLittleDucks;
            }
            set
            {
                foreach (var item in value)
                {
                    if (item.isLittle)
                    {
                        AllLittleDuckCount++;
                        allLittleDucks.Add(item);
                    }
                }
            }
        }

        public int AllLittleDuckCount {
            get
            {
               return allLittleDucks.Count;
            } set { currentBreadCount = value; } }

        public Duck(string name, bool isLittle)
        {
            Name = name;
            currentBreadCount = 0;
            currentLake = "SunnyLake";
            haveCuteLittleDucks = false;
            Weight = 100;
            Description = "Уточка по имени " + name;
            this.isLittle = isLittle;
            IsHungry = true;
            allLittleDucks = new List<Duck>();
            AllLittleDuckCount = allLittleDucks.Count;
        }

        internal void Eat(int breadCount)
        {
            currentBreadCount += breadCount;
            Weight += breadCount;
            if (currentBreadCount > 100)
            {
                this.IsHungry = false;
                this.allLittleDucks.AddRange(CreateCuteLittleDucks());
            }
            else
            {
                IsHungry = true;
            }
        }

        private List<Duck> CreateCuteLittleDucks()
        {
            currentBreadCount -= 100;
            Weight -= 100;
            return new List<Duck>() { new Duck("Уточка", true), new Duck("Утёнок", true) };
        }
    }
}
