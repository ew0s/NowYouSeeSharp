namespace l5t1
{
    public class Cow : Animal
    {
        public Cow(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return name;
        }
    }
}
