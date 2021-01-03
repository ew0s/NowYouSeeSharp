using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t14
{
    /*
     * Реализуй недостающие методы у классов Cat и Dog, они не должны быть абстрактными.
     */

    public abstract partial class Pet
    {
        public string Breed { get; set; }
        public Pet Child { get; set; }

        public abstract string GetBreed();

        public abstract Pet GetChild();


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
    }
}
