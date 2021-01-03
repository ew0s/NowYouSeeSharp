using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t16
{
    [Serializable]
    public class SmartBird
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Missions { get; set; }

        public SmartBird() {}

        public SmartBird(string name, int age, string[] missions)
        {
            Name = name;
            Age = age;
            Missions = missions;
        }
    }
}
