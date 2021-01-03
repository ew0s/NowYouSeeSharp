using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t4
{
    /*
     * Измените шаблон задачи таким образом, чтобы все типы локальных переменных метода Main() и блоков кода foreach были заданы явно.
     */
    
    public class Program
    {
        public static void Main(string[] args)
        {
            List<List<List<string>>> l = new List<List<List<string>>>();
            foreach (List<List<string>> item in l)
            {
                foreach (List<string> cool in item)
                {
                    foreach (string staff in cool)
                    {
                        Console.WriteLine(staff);
                    }
                }
            }
        }
    }
}
