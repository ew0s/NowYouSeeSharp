using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t8
{
    /*
     * Измените метод DummyMethod() таким образом, чтобы по окончанию его работы все 
     * его потоки корректно высвободили выделенные им ресурсы.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public void DummyMethod()
        {
            using (FileStream fileStream1 = new FileStream("Program.cs", FileMode.Open)){}

            using (FileStream fileStream2 = new FileStream("Program.cs", FileMode.Open)){}

            using (FileStream fileStream3 = new FileStream("Program.cs", FileMode.Open)){}

            using (FileStream fileStream4 = new FileStream("Program.cs", FileMode.Open)){}

            using (FileStream fileStream5 = new FileStream("Program.cs", FileMode.Open)){}
            /* Добавьте свой код ниже */
        }
    }
}
