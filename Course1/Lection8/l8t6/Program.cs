using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t6
{
    /*
     * Внутри метода Main() объедините 2 коллекции - listA и listB, результат объединения поместите в третью коллекцию listX.
     * Сначала должны идти элементы коллекции listB, а затем коллекции listA. Коллекция listX не должна содержать элементов,
     * которые одновременно присутствуют в обеих исходных коллекциях. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static List<int> listA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public static List<double> listB = new List<double>() { 1, 2.2, 3.0, 4.4, 5, 6, 9.1, 10.2, 11.2, 3, 10.1, 10.2 };
        public static List<float> listX = new List<float>() { };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<object> tmpList = new List<object>();
            foreach (double value in listB)
            {
                tmpList.Add(value);
            }

            foreach (double value in listA)
            {
                if (tmpList.Contains(value))
                {
                    while (tmpList.Contains(value))
                    {
                        tmpList.Remove(value);
                    }
                    continue;
                }

                tmpList.Add(value);
            }

            for (int i = 0; i < tmpList.Count; i++)
            {
                listX.Add(float.Parse(tmpList[i].ToString()));
            }
        }
    }
}
