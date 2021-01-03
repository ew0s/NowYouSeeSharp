using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t21
{
    /*
     * Создайте метод GetAllFileFromDirectory(), который:
     *      1) Принимает путь к директории на жестком диске.
     *      2) Возвращает список строк, который содержит перечень всех файлов в указанной директории,
     *         с указанием их имени и расширения с разделителем в виде точки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static List<string> GetAllFileFromDirectory(string path)
        {
            if (!Directory.Exists(path)) return null;
            var outList = new List<string>();

            foreach (var file in Directory.GetFiles(path))
            {
                FileInfo fileInfo = new FileInfo(file);
                outList.Add(fileInfo.Name);
            }

            return outList;
        }
    }
}
