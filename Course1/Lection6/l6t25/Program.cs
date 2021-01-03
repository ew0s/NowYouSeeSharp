using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t25
{
    /*
     * Реализуйте метод LookMomNoHands(), который должен возвращать массив, в котором все элементы столбцов принятого массива 
     * отсортированы в порядке возрастания элементов. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[5][];
            arr[0] = new int[] { 1, 2, 1, 0, 7 };
            arr[1] = new int[] { 2, 4, 1, 5, 7 };
            arr[2] = new int[] { 3, 1, 7, 3, 2 };
            arr[3] = new int[] { 0, 3, 8, 1, 1 };
            arr[4] = new int[] { 4, 5, 3, 0, 2 };
            arr = LookMomNoHands(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] LookMomNoHands(int[][] arr)
        {
            /* Добавьте свой код ниже */
            List<List<int>> tmpList = new List<List<int>>(new List<int>[arr.Length / arr.Rank]);
            for (int i = 0; i < tmpList.Count; i++)
            {
                tmpList[i] = new List<int>();
            }


            for (int i = 0; i < arr.Length / arr.Rank; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    tmpList[i].Add(arr[j][i]);
                }
            }

            for (int i = 0; i < tmpList.Count; i++)
            {
                tmpList[i].Sort();
            }

            for (int i = 0; i < arr.Length / arr.Rank; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[j][i] = tmpList[i][j];
                }
            }

            return arr;
        }
    }
}
