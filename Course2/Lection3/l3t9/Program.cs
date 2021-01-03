using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t9
{
    /*
     * Создайте и объявите сигнатуру метода Move() в интерфейсе IMovable так, чтобы при работе с экземпляром
     * класса Human, он увеличивал координаты его текущего положения в соответствии со значениями аргумента при вызове.
     * 
     * Координаты будут подаваться в том же порядке, в котором они объявлены внутри класса Human.
     * Реализуйте интерфейс IMovable для класса Human. 
     * Остальные элементы класса Human изменять нельзя.
     */

    public class Human : IMovable
    {
        public string Name { get; set; }
        public string currentLocation { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Human(string name, string currentLocation, int x, int y, int z)
        {
            Name = name;
            this.currentLocation = currentLocation;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static void Main(string[] args)
        {
            
        }

        /* Добавьте свой код ниже */
        public void Move(int x, int y, int z)
        {
            this.x += x;
            this.y += y;
            this.z += z;
        }
    }
}
