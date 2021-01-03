using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t10
{
    /*
     * Внутри метода Main() создайте 3 произвольных потока ввода-вывода с использованием
     * оператора using.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            using (FileStream fs = new FileStream("d", FileMode.Create))
            {
                
            }
            using (FileStream fs = new FileStream("d", FileMode.Create))
            {
                
            }
            using (FileStream fs = new FileStream("d", FileMode.Create))
            {
                
            }
        }
    }
}
