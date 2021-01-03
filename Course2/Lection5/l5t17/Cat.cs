using System;

namespace l5t17
{
    public class Cat : Animal
    {
        protected virtual string TripleWriter(string s)
        {
            return s + s + s;
        }

        protected virtual long Factorial(int b)
        {
            if (b >= 10)
            {
                throw new NotSupportedException();
            }
            else
            {
                int x = 1;
                for (int i = 0; i < b; i++)
                {
                    x *= i + 1;
                }
                return x;
            }
        }
    }
}