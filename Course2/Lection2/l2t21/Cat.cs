namespace l2t21
{
    public class Cat
    {
        private string name;
        private int age;
        private int weight;

        public Cat(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public static Cat operator +(Cat lValueCat, Cat rValueCat)
        {
            return new Cat(string.Concat(rValueCat.name, lValueCat.name), lValueCat.age + rValueCat.age, lValueCat.weight + rValueCat.weight);
        }
        public override string ToString()
        {
            return $"Ты чего наделал??? Теперь меня зовут {name}, мой возраст {age} и вешу я аж {weight}";
        }
    }
}
