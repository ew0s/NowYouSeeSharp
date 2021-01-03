using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t8
{
    [AttributeUsage(AttributeTargets.Field)]
    public class RandomBreedAttribute : Attribute
    {
        private static string[] allBreeds;
        private static Random r = new Random();

        public RandomBreedAttribute(string[] strings)
        {
            allBreeds = strings;
        }

        public string GetBreed()
        {
            return allBreeds[r.Next(0, allBreeds.Length)];
        }
    }
}
