using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t30
{
    public class Sheep
    {
        public string name;
        public int weight;
        public int age;
        public bool haveSharpTeeth;
        private int sheepCount;
        public bool isHungry;

        public Sheep(string name, int weight, int age, bool isHungry)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.isHungry = isHungry;
            haveSharpTeeth = default;
            sheepCount = default;
        }

        public Sheep(Wolf wolf) : this(wolf.name, wolf.weight, wolf.age, wolf.isHungry)
        {
            sheepCount = wolf.sheepCount;
            haveSharpTeeth = wolf.haveSharpTeeth;
            name = "Wolfy-" + wolf.name.Replace("Wolfy-", "").Replace("-WhySoWolfy", "");
        }

        public static implicit operator Wolf(Sheep sheep)
        {
            return new Wolf(sheep);
        }
    }
}
