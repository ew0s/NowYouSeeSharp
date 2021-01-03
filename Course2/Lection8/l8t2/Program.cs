using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t2
{
    /*
     * Внутри метода Main() созданы 3 потока, для каждого из которых:
     *      1) Принудительно сбросьте все локальные и буферизированные данные потока.
     *      2) Закройте поток, высвободив все выделенные ему ресурсы.
     * Базовый шаблон метода Main() изменять нельзя.  
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            var s1 = new FileStream(@"Program.cs", FileMode.Open);
            var s2 = new BufferedStream(s1);
            var s3 = new FileStream(@"Program.cs", FileMode.Append);

            s1.Flush();
            s2.Flush();
            s3.Flush();

            s1.Close();
            s2.Close();
            s3.Close();
            /* Добавьте свой код ниже */
        }
    }
}
