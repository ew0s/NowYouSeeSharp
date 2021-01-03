using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t8
{
    [Serializable]
    public class SpaceCat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> EnemyList { get; set; }
    }
}
