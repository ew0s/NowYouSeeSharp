using System;

namespace l3t14
{


    public abstract partial class Pet
    {
        public class Cat : Pet
        {
            public override string GetBreed()
            {
                return Breed;
            }

            public override Pet GetChild()
            {
                return Child;
            }
        }

    }
}
