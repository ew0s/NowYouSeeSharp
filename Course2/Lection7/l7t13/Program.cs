using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t13
{
    /*
     * Проанализируйте код программы. Сейчас она работает не корректно, необходимо внести
     * соответствующие правки, чтобы каждый из создаваемых потоков выводил в консоль имена 
     * своего персонажа с числами от 0 до 24 и только после этого вызывался другой поток.
     * Шаблон метода Main() изменять нельзя, при этом оператор lock использовать запрещено.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            ProxyClass B = new ProxyClass();
            ProxyClass B1 = new ProxyClass();
            ProxyClass B2 = new ProxyClass();
            ProxyClass B3 = new ProxyClass();
        }
    }
}
