using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t18
{
    /*
     * Переопределите метод SayMeow() таким образом, чтобы он выводил в консоль слово "Мяу" с количеством букв "я" в нём, 
     * равным полученному значению целого числа, передаваемого в метод.
     */

    public class Animal
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Animal animal = new Animal();
            animal.SayMeow();
            Cat cat = new Cat();
            cat.SayMeow(5);
        }

        public virtual void SayMeow()
        {
            Console.WriteLine("Мяу");
        }

        public virtual void SayMeow(int number)
        {}

        
    }
}
