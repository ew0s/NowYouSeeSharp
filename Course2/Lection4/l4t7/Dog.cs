using System.CodeDom;
using System.Reflection;

namespace l4t7
{
    [MyClientCount(typeof(Dog), 0)]
    public class Dog
    {
        private int _age;
        public int Age {
            get
            {
                return _age;
            }
            set
            {
               var attribute = new Dog().GetType().GetCustomAttribute(typeof(MyClientCountAttribute));
               if (attribute != null)
               {
                   var attributeValue = (MyClientCountAttribute) attribute;
                   if (attributeValue.DogValue <= value) _age = value;
                   else _age = attributeValue.DogValue;
               }
            }
        }
    }
}
