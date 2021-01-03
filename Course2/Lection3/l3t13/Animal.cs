namespace l3t13
{
    public abstract class Animal
    {
        public int weight;
        public int age;
        public string name;

        public Animal(int weight, int age, string name)
        {
            this.age = age;
            this.name = name;
            this.weight = weight;
        }

        public abstract void Say();
    }

}
