using System;

namespace l5t4
{
    public class B : A
    {
        protected int f1 = 3;

        public B(int f1) : base(f1)
        {
            this.f1 += f1;
            Initialize();
        }

        protected void Initialize()
        {
            Console.WriteLine(f1);
        }
    }
}
