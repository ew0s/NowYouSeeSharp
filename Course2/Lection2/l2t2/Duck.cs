using System;
using System.Runtime.InteropServices;

namespace l2t2
{
    internal class Duck : Animal
    {
        public override void Say()
        {
            Console.WriteLine("Я говорю КРЯ-КРЯ");
        }
    }
}