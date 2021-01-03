using System;

namespace l4t3
{
    public class NYSSAttribute : Attribute
    {
        public NYSSAttribute(string message)
        {
            Console.WriteLine($"Когда ко мне обратятся - я отработаю ... и выведу: {message}");
        }
    }
}
