namespace l3t14
{


    public abstract partial class Pet
    {
        public class Dog : Pet
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
