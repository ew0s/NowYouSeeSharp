using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t11
{
    /*
     * Для всех полей класса Program запретите кеширование их значений.
     */

    public class Program
    {
        public volatile static int x;
        public volatile static string s;
        public volatile char d;
        public volatile Program p;
        public volatile short m;
    }
}
