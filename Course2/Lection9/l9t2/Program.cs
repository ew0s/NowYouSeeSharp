using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t2
{
    /*
     * Для класса AvengerCat:
     *      1) Добавьте свойство Name.
     *      2) Добавьте свойство Age.
     *      3) Добавьте свойство Power.
     *      4) Добавьте свойство FragsCount.
     *      5) Добавьте свойство ShortDescription.
     * Добавьте для созданного класса поддержку сериализации, за исключением полей ссылочного типа.  
     */

    [Serializable]
    public class AvengerCat
    {
        [NonSerialized] private string name;
        [NonSerialized] private string shortDescription;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age { get; set; }
        public int Power { get; set; }
        public int FragsCount { get; set; }

        public string ShortDescription
        {
            get
            {
                return shortDescription;
            }
            set
            {
                shortDescription = value;
            }
        }

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
    }
}
