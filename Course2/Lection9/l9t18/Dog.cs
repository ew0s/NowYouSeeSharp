namespace l9t18
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog() {}

        public override string ToString()
        {
            return $"Грустно собачке {Name} жить {Age} лет в XML, но выбора нет...";
        }
    }
}
