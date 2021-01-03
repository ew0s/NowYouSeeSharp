using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace l8t23
{
    /*
     * Внутри метода Main() достаньте из архива SmallTestArchive.zip все его файлы
     * и выведите в консоль их имена, каждое имя с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            ZipFile zip = new ZipFile(@"C:\Users\ew0s\Education\Course2\Lection8\l8t23\SmallTestArchive.zip");
            foreach (var zipEntryFileName in zip.EntryFileNames)
            {
                Console.WriteLine(zipEntryFileName);
            }
        }
    }
}
