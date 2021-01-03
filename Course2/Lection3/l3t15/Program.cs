using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace l3t15
{
    /*
     * Создайте 2 интерфейса: IMovable и ISwimmable (каждый в своём файле). Для каждого из них определите 
     * и создайте основной метод, который бы характеризовал каждый из интерфейсов. Реализуйте класс человек,
     * добавьте в него наследование от обоих интерфейсов, но не реализовывайте ни 1 из методов интерфейса. 
     * Сделайте так, чтобы код скомпилировался.
     */

    public abstract class Human : ISwimmable, IMovable
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public abstract void Swim();

        public abstract void Move();
    }
}
