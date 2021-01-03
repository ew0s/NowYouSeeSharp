using System;

namespace l4t7
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MyClientCountAttribute : Attribute
    {
        public int CatValue { get; }
        public int DogValue { get; }

        public MyClientCountAttribute(Type type, int count)
        {
            switch (type.Name)
            {
                case "Dog":
                    DogValue = count;
                    break;
                case "Cat":
                    CatValue = count;
                    break;
            }
        }
    }
}
