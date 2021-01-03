using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t9
{
    /*
     * Внутри неймспейса класса Program создайте структуру ExerciseResult, которая:
     *      1) Содержит два публичных целочисленных поля: position и value.
     *      2) Конструктор, принимающий и устанавливающий оба значения.
     * Для класса OptimisticCalc создайте базовую реализацию метода Calc, которая принимает массив 
     * целых чисел и возвращает позицию и значение максимального элемента массива. Тип возвращаемого значения
     * определите самостоятельно, при этом исходящих параметров метод иметь не должен.
     * Для дочернего класса MinPair переопределите логику метода Calc так, чтобы он возвращал минимальное 
     * число и его позицию в принятом массиве.
     * 
     * Своё решение и его логику можете проверить в методе Main(), он не будет учитываться при проверке решения!
     * 
     */

    public class Program
    {
        static int[] integers = new int[] { 1, 2, 3, 4, 5, 6, 7, -8, 9, 10 };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            OptimisticCalc optimisticCalc = new OptimisticCalc();
            MinPair minPair = new MinPair();

            Console.WriteLine(optimisticCalc.Calc(integers).value);
            Console.WriteLine(minPair.Calc(integers).value);

            Console.WriteLine(optimisticCalc.Calc(integers).position);
            Console.WriteLine(minPair.Calc(integers).position);
        }
    }

    public struct ExerciseResult
    {
        public int position;
        public int value;

        public ExerciseResult(int position, int value)
        {
            this.position = position;
            this.value = value;
        }
    }
}

