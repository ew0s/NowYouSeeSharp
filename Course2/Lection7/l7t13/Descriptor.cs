using System;
using System.Threading;

namespace l7t13
{
    public class Descriptor
    {
        public static object locker = new object();

        public void PepePrinter()
        {
            bool trigger = false;
            try
            {
                Monitor.Enter(locker, ref trigger);
                for (int x = 0; x < 25; x++)
                {
                    Thread.Sleep(50);
                    Console.WriteLine("Pepe {0}", x);
                }
            }
            finally
            {
                if (trigger)
                {
                    Monitor.Exit(locker);
                }
            }
        }

        public void JohnPrinter()
        {
            bool trigger = false;

            try
            {
                Monitor.Enter(locker, ref trigger);
                for (int x = 0; x < 25; x++)
                {
                    Thread.Sleep(50);
                    Console.WriteLine("John {0}", x);
                }
            }
            finally
            {
                if (trigger)
                {
                    Monitor.Exit(locker);
                }
            }
        }
    }
}
