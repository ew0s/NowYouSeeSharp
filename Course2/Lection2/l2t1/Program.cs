using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t1
{
    /*
     *  Постройте цепочку наследования для классов Plane, PaperPlane, Airplane и StarShip так, 
     *  чтобы программа скомпилировалась.
     */

    public class Airport
    {
        public static void Main(string[] args)
        {
            new Plane().Fly();
            new PaperPlane().Fly();
            new Airplane().Fly();
            new StarShip().Fly();
        }
    }
}
