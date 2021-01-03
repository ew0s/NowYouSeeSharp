namespace l3t22
{
    public abstract class Animal : IMeow, IFly
    {
        public string name;
        public int age;
        public int weight;
        public string address;
        public bool isHungry;

        public abstract void Meow();
        public abstract void Fly();
    }
}
