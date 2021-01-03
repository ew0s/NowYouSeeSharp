using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t30
{
    /*
     * Перегрузите оператор явного приведения для класса Wolf таким образом, чтобы в результате операции
     * получался новый экземпляр класса Sheep, значения полей которого полностью совпадают с исходными, но:
     *      1) Определите те поля, которые явно не могут иметь какие-либо значения для овечек, получившихся
     *         таким странным образом...
     *      2) Создайте два конструктора для класса Sheep: первый для стандартной овечки, второй для
     *         получившегося волка в овечьей шкуре. 
     *         2.1) Конструктор для стандартной овечки должен последовательно принимать и устанавливать 
     *              соответствующие поля класса, при этом оставшиеся поля должны иметь значения по умолчанию.
     *         2.2) Конструктор для нестандартной овечки должен принимать экземпляр волка и устанавливать двум
     *              оставшимся полям получившегося класса значения отличные от значений по умолчанию.
     *      3) Каждый получившийся в результате приведения экземпляр должен иметь имя с префиксом Wolfy, 
     *         записанным через дефис.
     * Перегрузите оператор неявного приведения для класса Sheep таким образом, чтобы в результате операции
     * получался новый экземпляр класса Wolf, поведение конструкторов класса и логика преобразования должна
     * быть аналогичной поведению, реализованному для класса Wolf, но имя получившегося в результате преобразования
     * экземпляра: не должно иметь префикса, а должно иметь постфикс "WhySoWolfy", записанный через дефис.
     */

    public class Wolf
    {
        public string name;
        public int weight;
        public int age;
        public bool haveSharpTeeth;
        public int sheepCount;
        public bool isHungry;

        public static void Main(string[] args)
        {
           
        }

        public Wolf(string name, int weight, int age, bool isHungry)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.isHungry = isHungry;
        }

        public Wolf(Sheep sheep) : this(sheep.name, sheep.weight, sheep.age, sheep.isHungry)
        {
            this.sheepCount = 123;
            this.haveSharpTeeth = true;
            this.name = sheep.name.Replace("Wolfy-", "").Replace("-WhySoWolfy", "") + "-WhySoWolfy";
        }

        public static explicit operator Sheep(Wolf wolf)
        {
            return new Sheep(wolf);
        }
    }
}
