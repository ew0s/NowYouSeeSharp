using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t23
{
    /*
     * Создайте статический метод GetMostCommonElement(), который должен принимать массив строк и возвращать
     * наиболее часто встречающийся элемент массива. Если таких элементов несколько - выведите тот, 
     * который имееет наименьший индекс первого элемента. Внутри метода Main() выведите на экран результат 
     * вызова метода GetMostCommonElement(), передав значение входящего параметра метода Main() в качестве аргумента.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(GetMostCommonElement(args));
        }
        /* Добавьте свой код ниже */
        public static string GetMostCommonElement(string[] args)
        {
            List<string> list = new List<string>(args);

            int maxQuantity = Int32.MinValue;
            string maxQuantutyString = null;

            for (int i = 0; i < list.Count; i++)
            {
                int currQuantity = 0;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        currQuantity++;
                    }
                }

                if (currQuantity <= maxQuantity) continue;
                maxQuantutyString = list[i];
                maxQuantity = currQuantity;
            }

            return maxQuantutyString;
        }

    }
}
