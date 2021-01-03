using System;

namespace l5t17
{
    public class Animal : Things
    {
        protected override int Calc(int a, int b, string operation)
        {
            throw new NotImplementedException();
        }

        protected virtual void Say(string s)
        {
            Console.WriteLine(s);
        }
    }
}