using System;
using System.Collections.Generic;

namespace l7t7
{
    public class Cat
    {
        private string name;
        private List<string> description = new List<string>() { "Это", " ", "описание", " ", "котика", " ", "и", " ", "его", " ", "зовут", " Мистер Котик!" };

        public void Talk()
        {
            foreach (var item in this.description) 
            { 
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
