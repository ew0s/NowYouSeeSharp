using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t3
{
    /*
     * Проанализируйте шаблон. Исправьте все ошибки и сделайте так, чтобы в консоль было выведено «Летает», 
     * «Двигается», каждое слово с новой строки. 
     * Шаблон класса Program менять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Duck duck = new Duck();

            Obj.Fly(duck);
            Obj.Move(duck);
        }
    }
}
