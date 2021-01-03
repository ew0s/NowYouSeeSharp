using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t3
{
    /*
     * Разберитесь почему программа не компилируется. Исправьте дочерние классы так, чтобы программа 
     * скомпилировалась, а вывод в консоль соответствовал логике используемых классов.
     * 
     * Код классов Program и Animal изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            new Animal("где нравится!").WhereILive();
            new Elepfant("в Африке!").WhereILive();
            new Penguin("там где холодно!").WhereILive();
            new Sparrow("в зоопарке у зверей!").WhereILive();            
        }
    }
}
