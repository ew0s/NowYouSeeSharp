using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t12
{
    /*
     * Проанализируйте что делает программа, после чего, разнесите все созданные классы по соответствующим файлам.
     * Сделайте так, чтобы программа скомпилировалась и в результате работы метода Main() все значения выводимые в консоль
     * были истиной.
     * Код метода Main() изменять нельзя.
     */

    public class Program
    {
        private static List<Mouse> MouseList = new List<Mouse>();
        private static List<Dog> DogList = new List<Dog>();
        private static List<Cat> CatList = new List<Cat>();

        public static int MouseCount { get; set; }
        public static int DogCount { get; set; }
        public static int CatCount { get; set; }


        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                MouseList.Add(new Mouse(i, "Мышка" + i));
                DogList.Add(new Dog(i, "Собачка" + i));
                CatList.Add(new Cat(i, "Кошечка" + i));
            }
            Console.WriteLine(MouseList.Count == MouseCount);
            Console.WriteLine(DogList.Count == DogCount);
            Console.WriteLine(CatList.Count == CatCount);
        }
    }
}
