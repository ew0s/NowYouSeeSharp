using System;

namespace l3t13
{
    public class Dog : Animal
    {
        public int boneCount;

        public Dog(int weight, int age, string name, int boneCount) : base(weight, age, name)
        {
            this.boneCount = boneCount;
        }

        public override void Say()
        {
            Console.WriteLine("Гав-гав");
        }
    }

}
