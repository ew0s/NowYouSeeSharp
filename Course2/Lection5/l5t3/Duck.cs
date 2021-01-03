using System;
using System.Runtime.InteropServices;

namespace l5t3
{
    public class Duck : IFlyable, IMovable
    {
        public void FlyAction()
        {
            Console.WriteLine("Летает");
        }

        public void MoveAction()
        {
            Console.WriteLine("Двигается");
        }
    }

}
