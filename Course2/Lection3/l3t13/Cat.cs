using System;

namespace l3t13
{
    public class Cat : Animal
    {
        public Cat(int weight, int age, string name) : base(weight, age, name)
        {
        }
        public override void Say()
        {
            Console.WriteLine("Мяяяу");
        }
    }

}
