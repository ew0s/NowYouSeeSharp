namespace l2t17
{
    public class Cat
    {
        public int Age { get; set; }
        public int Weight { get; set; }

        public Cat(int age, int weight)
        {
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Толстенькому котику {Age} лет! Пора бы сесть на диету, а то он уже весит аж {Weight} килограмм!";
        }
    }
}
