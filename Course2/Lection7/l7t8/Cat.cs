using System;
using System.Collections.Generic;

namespace l7t8
{
    public class Cat
    {
        private string name;
        public List<string> description = new List<string>() { "Это", " ", "описание", " ", "котика", " ", "и", " ", "его", " ", "зовут", " " };

        public Cat(string name)
        {
            this.name = name;
            description.Add(name);
        }
    }
}
