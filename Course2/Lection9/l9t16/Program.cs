using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace l9t16
{
    /*
     * В корне проекта находится файл, содержащий экземпляр класса в XML представлении.
     * Создайте в новом файле класс SmartBird на основе анализа данных файла, после чего
     * создайте публичный статический метод GetFreshBird() для класса Program, который:
     *      1) Последовательно принимает значения всех полей класса SmartBird, создаёт
     *         новый экземпляр класса SmartBird.
     *      2) Созданный экземпляр класса SmartBird должен сохраняться в файле SmartBirdsList.xml
     *      3) В случае, если файл не пустой, в файле должен сохраниться только последний
     *         сериализуемый экземпляр класса.
     *      4) Возвращать созданный экземпляр класса.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static SmartBird GetFreshBird(string name, int age, string[] missions)
        {
            using (FileStream fs = new FileStream(@"C:\Users\ew0s\Education\Course2\Lection9\l9t16\bin\Debug\SmartBirdsList.xml", FileMode.Create))
            {
                var newBird = new SmartBird(name, age, missions);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SmartBird));
                xmlSerializer.Serialize(fs, newBird);
                return newBird;
            }
        }
    }
}
