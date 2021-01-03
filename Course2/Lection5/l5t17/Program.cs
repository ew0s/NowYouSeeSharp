using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t17
{
    /*
     * Реализуйте класс ProxyCat таким образом, чтобы он содержал все методы классов, с которыми он имеет
     * родственные связи. При этом логика работы таких методов не должна изменяться, за исключением уровня
     * их видимости - они должны стать доступны для использования из любого класса в программе.
     * Остальные элементы шаблона изменять нельзя.
     */

    public class ProxyCat : Cat
    {
        public static void Main(string[] args)
        {
            
        }

        /* Добавьте свой код ниже */
        public new int Calc(int a, int b, string operation)
        {
            return base.Calc(a, b, operation);
        }

        public new long Factorial(int b)
        {
            return base.Factorial(b);
        }

        public new void Say(string s)
        {
            base.Say(s);
        }

        public new string TripleWriter(string s)
        {
            return base.TripleWriter(s);
        }
    }
}
