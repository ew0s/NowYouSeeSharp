using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t19.Armory
{
    public class Armor
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int PhysicalDefence { get; set; }
        //public int MagicalBonus { get; set; }
        //public int AgilityBonus { get; set; }
        //public int ProtectionBonus { get; set; }
        public CharacterClass GameClass { get; set; }
        public bool IsBroken { get; set; }
    }
}
