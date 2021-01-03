using System;

namespace l5t4
{
    public class A
    {
        private int f1 = 7;

        public A(int f1)
        {
            this.f1 = f1;
            Initialize();
        }

        protected void Initialize()
        {
            Console.WriteLine(f1);
        }
    }
}
