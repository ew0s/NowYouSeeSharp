namespace l5t1
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return name;
        }
    }
}
