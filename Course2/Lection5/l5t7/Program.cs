using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t7
{
    /*
     * Внутри метода Main() исправьте текущий код программы, преобразовав совместимые типы 
     * с использованием оператора as.
     * Остальные элементы шаблона изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Cat c1 = new MainCoon("Киса");
            Cat c2 = new Pers("Персик");
            Cat.CatInfo(c1 as MainCoon);
            Cat.CatInfo(c2 as Pers);
        }
    }
}
