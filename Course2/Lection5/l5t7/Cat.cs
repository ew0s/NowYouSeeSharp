using System;

namespace l5t7
{
    public class Cat
    {
        protected string name;

        public static void CatInfo(MainCoon cat)
        {
            Console.WriteLine($"Мейнкунчик по имени: {cat.name}");
        }

        public static void CatInfo(Pers cat)
        {
            Console.WriteLine($"Персидский котик по имени: {cat.name}");
        }
    }
}
