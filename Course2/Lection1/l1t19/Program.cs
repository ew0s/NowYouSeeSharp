using l1t19.Armory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t19
{
    /*
     * Внутри неймспейса Armory даны 4 класса, между которыми существует явная наследственная связь.
     * Установите её при помощи механизма наследования, после чего:
     *      1) Определите какие из элементов описания родительского класса являются общими для всех классов,
     *         а какие частными для наследников.
     *      2) Разнесите частные элементы из родительского класса по дочерним, оставив в нём лишь общие элементы.
     *      3) Получившиеся классы не должны иметь повторяющихся и\или бесполезных полей.
     */

    public class Character
    {
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public Locations CurrentLocation { get; set; } = Locations.AligatorIslands;
        public CharacterClass CharacterClass = CharacterClass.Mage;
        public double Exp { get; set; }
        public Armor CurrentArmor { get; set; }
        public List<Armor> ArmorsInInventory { get; set; } = new List<Armor>();
    }

    public enum CharacterClass
    {
        Fighter,
        Rogue,
        Mage
    }

    public enum Locations
    {
        HomeIslands,
        AligatorIslands,
        IvoryTower,
        ForsakenPlains,
        BloodyOrcOutpost
    }
}
