using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t18
{
    /*
     * Даны 3 класса, между которыми необходимо установить правильные наследственные связи.
     * После установления связей необходимость в повторяющихся полях отпадёт, поэтому просто 
     * удалите их из классов потомков.
     */

    public class OpenSpace
    {
        public class SpaceAstraHM1000 : StarShip
        {
            //public string description;
            //public string shortName;
            //public int crewCount;
            public DateTime currentSpaceDate;
            //public bool canFly;
            public string model;
            public bool isProtonBlasterReady;
        }

        public class Ship
        {
            public string description;
            public string shortName; 
            public int crewCount;
            //public DateTime currentSpaceDate;
            //public bool canFly;
            //public string model;
            //public bool isProtonBlasterReady;
        }

        public class StarShip : Ship
        {
            //public string description;
            //public string shortName;
            //public int crewCount;
            //  public DateTime currentSpaceDate;
            public bool canFly;
            //public string model;
            //public bool isProtonBlasterReady;
        }
    }
}
