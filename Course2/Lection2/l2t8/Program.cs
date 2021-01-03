using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t8
{
    /*
     * Проанализируйте логику выполнения программы. Сейчас она работает, но результат выполнения операций не
     * соответствует ожидаемым. Определите причину и внесите соответствующие изменения.
     * 
     * Код класса CatVillage изменять нельзя!
     */

    public class CatVillage
    {
        static Random random = new Random();

        public static void Main(string[] args)
        {
            try
            {
                var proger =  new ProgrammerCat() { Name = "Chad" };
                var teacher = new CatTeacher() { Name = "Teddy" };
                proger.DoWork(random.Next(5000,500000));
                teacher.DoWork(random.Next(500,5000));
                Console.WriteLine(proger.Describe());               
                Console.WriteLine(teacher.Describe());               
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Ну вот как-то не понятно..."); ;
            }
        }
    }
}
