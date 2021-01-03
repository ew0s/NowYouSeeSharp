namespace l5t11
{
    public class Lion : Animal
    {
        public double Speed { get; set; }

        public Lion(string name, int age, double speed) : base(name, age)
        {
            Speed = speed;
        }
    }
}
