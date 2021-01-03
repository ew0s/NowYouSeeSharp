using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t11
{
    /*
     * В том же неймспейсе что и класс SimpleCalc:
     *      1) Создайте 4 класса: Sum, Sub, Div, Mul, каждый их которых соответственно отвечает за сложение\вычитание\деление\умножение\
     *         целых чисел.
     *      2) Создайте класс Operation, после чего установите наследственные связи между всеми пятью созданными классами.
     * Внутри класса Operation:
     *      1) Задайте публичный метод Calculate, который должен отвечать за выполнение соответствующих операций
     *         у потомков класса Operation.
     *      2) Сигнатуру метода Calculate определите самостоятельно.
     *      3) Переопределите метод Calculate для всех потомков класса Operation.
     *      4) Метод Calculate базового класса должен выбрасывать исключение, отображающее отсутствие базовой реализации.
     * Внутри метода Main() последовательно выведите в консоль, результат следующих операций:
     *      1) 7 + 7
     *      2) 1 * -99
     *      3) 100 / 0
     *      4) -100 / 0
     *      5) -11 - 11
     * Деление на 0 в классе Div не должно вызывать исключений, а результат должен возвращаться ожидаемым для текущего типа возвращаемого значения.
     */

    public class SimpleCalc
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Operation operationDiv = new Div();
            Operation operationMul = new Mul();
            Operation operationSum = new Sum();
            Operation operationSub = new Sub();

            Console.WriteLine(operationSum.Calculate(7, 7));
            Console.WriteLine(operationMul.Calculate(1, -99));
            Console.WriteLine(operationDiv.Calculate(100, 0));
            Console.WriteLine(operationDiv.Calculate(-100, 0));
            Console.WriteLine(operationSub.Calculate(-11, 11));
        }
    }
}
