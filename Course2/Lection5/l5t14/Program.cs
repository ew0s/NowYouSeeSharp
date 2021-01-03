using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t14
{
    /*
     * Для класса OldCalculator создайте статический метод Mult(), который:
     *      1) Доступен для вызова только из классов потомков.
     *      2) Принимает зубчатый массив целых чисел.
     *      3) Возвращает квадрат наибольшего значения, взятого по модулю.
     *      4) Тип возвращаемого значения long.
     *      5) В случае если принятый массив пустой или содержит хотя бы одно значение по умолчанию - 
     *         метод должен выбрасывать NotInThisTimeExeption.
     */

    public class OldCalculator
    {
        protected static long Mult(params int[][] intArray)
        {
            if (intArray.Length == 0 || intArray == null)
            {
                throw new NotInThisTimeExeption();
            }

            long maxValue = long.MinValue;
            
            foreach (var row in intArray)
            {
                if (row == null)
                {
                    throw new NotInThisTimeExeption();
                }
                foreach (var value in row)
                {
                    if (Math.Abs(value) > maxValue)
                    {
                        maxValue = Math.Abs(value);
                    }
                }
            }

            return maxValue >= 0 ? maxValue * maxValue : throw new NotInThisTimeExeption();
        }
    }
}
