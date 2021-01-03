using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t15
{
    [Serializable]
    public class SpaceCat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] MissionsList { get; set; }
        public string Description { get; set; }
        public long GalaxyCredits { get; set; }

        public SpaceCat() {}

        public SpaceCat(string name, int age, string[] missionsList, string description, long galaxyCredits)
        {
            Name = name;
            Age = age;
            MissionsList = missionsList;
            Description = description;
            GalaxyCredits = galaxyCredits;
        }
    }
}
