using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t9
{
    /*
     * Проанализируйте шаблон программы. Измените код метода Main() таким образом, 
     * чтобы даже в случае возникновения исключений ресурсы, используемые потоком,
     * были высвобождены корректно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("qweqwe.cs", FileMode.Open))
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine(fs.Name);
                }   
            }
        }
    }
}
