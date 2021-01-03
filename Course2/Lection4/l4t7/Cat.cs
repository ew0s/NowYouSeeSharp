using System.Reflection;
using System.Xml;

namespace l4t7
{
    [MyClientCount(typeof(Cat), 0)]
    public class Cat
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                var attribute = new Cat().GetType().GetCustomAttribute(typeof(MyClientCountAttribute));
                if (attribute != null)
                {
                    var attributeValue = (MyClientCountAttribute) attribute;
                    if (attributeValue.CatValue <= value) _age = value;
                    else _age = attributeValue.CatValue;
                }
            }
        }
    }
}
