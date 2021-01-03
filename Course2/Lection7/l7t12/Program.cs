using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t12
{
    /*
     * Для всех типов-значения, которые это поддерживают, запретите локальное кеширование данных в классе Program.
     */

    public class Program
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public volatile int speed;
        public (string, int) valueMonat;
        public (int, int) Salary { get; set; }
        public Program program;
    }
}
