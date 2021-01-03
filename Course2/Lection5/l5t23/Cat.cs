using System;

namespace l5t23
{
    public class Cat : Animal
    {
        public sealed override void Meow()
        {
            Console.WriteLine("Мяу");
        }
    }
}
