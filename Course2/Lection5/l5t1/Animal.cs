namespace l5t1
{
    public class Animal
    {
        public string name;

        public override string ToString()
        {
            return name;
        }

        public Animal(string name)
        {
            this.name = name;
        }
    }
}
