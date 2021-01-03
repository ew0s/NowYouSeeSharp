using System;

namespace l2t3
{
    internal class Animal
    {
        private string location;

        public Animal(string v)
        {
            this.location = v;
        }

        internal void WhereILive()
        {
            Console.WriteLine("Я живу " + location);
        }
    }
}