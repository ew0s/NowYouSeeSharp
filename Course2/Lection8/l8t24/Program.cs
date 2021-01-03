using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace l8t24
{
    /*
     * Внутри класса Program создайте и реализуйте публичный статический метод MakeArchive(), который:
     *      1) Принимает строку и число в качестве входящих параметров.
     *      2) Создает ZIP-архив, содержащий файл SmallCatList.txt, содержащий строковое представление
     *         из экземпляров класса StringCat в количестве равном принятому значению входящего параметра.
     *      3) Создаваемый методом архив должен располагаться по пути, соответствующему принятому 
     *         строковому параметру и иметь имя CatArc3000.
     *      4) Ничего не возвращает.
     * Шаблон класса StringCat изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            MakeArchive(Directory.GetCurrentDirectory(), 10);
        }

        public static void MakeArchive(string path, int count)
        {
            using (FileStream zipToCreate = new FileStream(path + "/CatArc3000.zip", FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                {
                    ZipArchiveEntry smallCatList = archive.CreateEntry("SmallCatList.txt");
                    using (StreamWriter writer = new StreamWriter(smallCatList.Open()))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            writer.WriteLine(new StringCat().ToString());
                        }
                    }
                }
            }
        }
    }
}
