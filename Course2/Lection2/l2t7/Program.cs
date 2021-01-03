using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t7
{
    /*
     * Создайте два класса Dog и Bird, унаследуйте их от класса Animal. Сделайте так, чтобы при создании каждого
     * нового экземпляра класса Dog и Bird их родительский класс подсчитывал общее количество созданных экземпляров 
     * как своих, так и классов потомков.
     * Результат подсчёта поместите в приватное статическое свойство TotalAnimalsCount класса Animal.
     */

    public class Animal
    {
        private static int TotalAnimalsCount { get; set; }

        public Animal()
        {
            TotalAnimalsCount++;
        }
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        
        }
    }
}
