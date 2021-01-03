using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t7
{
    /*
     * Внутри метода Main() класса Program создайте новый поток для метода Matrix(), после чего выведите в консоль
     * информацию о потоке в формате: "Имя потока: ХХХ, текущие показатели языка и региональной культуры потока: XXX,
     * имя запускаемого метода: XXX, который принимает входящий параметр класса: ХХХ", где
     * XXX - значения соответствующих параметров потока и вызываемого метода.
     * Шаблон метода Matrix не должен быть изменён.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread = new Thread(Matrix);
            ParameterizedThreadStart parameterized= new ParameterizedThreadStart(Matrix);
            thread.Start(7);
            Console.WriteLine($"Имя потока: {thread.Name}, текущие показатели языка и региональной культуры потока: {thread.CurrentCulture}, имя запускаемого метода: {parameterized.Method.Name}, который принимает входящий параметр класса: {parameterized.Method.GetParameters()[0].ParameterType.Name}");

        }

        public static void Matrix(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(o);
                }
                Console.WriteLine();
            }
        }
    }
}
