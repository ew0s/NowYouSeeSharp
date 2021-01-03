using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t26
{
    /*
     * В том же файле и namespace что и класс Program создайте:
     *      1) Новую публичную структуру ColoredSquare.
     *      2) Новое публичное перечисление Color с тремя значениями: Red, Green, Yellow.
     * Для структуры ColoredSquare:
     *      1) Объявите приватное поле  length - отвечающее за длину стороны квадрата, тип поля определите самостоятельно.
     *      2) Объявите приватное поле pic - отвечающее за картинку квадрата с использованием псевдографики, тип поля определите самостоятельно.
     *      3) Объявите приватное поле color - отвечающее за цвет отрисовки картинки квадрата с использованием псевдографики, тип поля определите самостоятельно.
     * Объявите приватный статический метод MakeFigurePic() в структуре ColoredSquare, который принимает длину стороны квадрата,
     * а возвращает картинку квадрата с использованием псевдографики, на основе следующей логики:
     *      1) Отрисовывается только внешний контур квадрата, символ для отрисовки единицы длины - "+".
     *      2) Внутренние элементы квадрата - пробельные символы.
     *      3) Каждый из символов отрисовки должен иметь дополнительный пробельный символ, чтобы фигура получилась ровной.
     * Объявите публичный метод PrintFigure() в структуре ColoredSquare, который:
     *      1) Ничего не возвращает.
     *      2) Отвечает за отрисовку экземпляра структуры в консоли.
     *      3) Устанавливает цвет отрисовываемой фигуры, путем установки соответствующего значения в свойство консоли.
     * Объявите конструктор для структуры ColoredSquare, который принимает длину стороны квадрата и его цвет, а устанавливает длину, цвет и картинку.
     * Внутри метода Main() создайте три экземпляра структуры ColoredSquare c длинной стороны 5 и цветами: красным, желтым и зеленым, после чего
     * отрисуйте все 3 созданных экземпляра в консоли.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            ColoredSquare square1 = new ColoredSquare(5, Color.Red);
            ColoredSquare square2 = new ColoredSquare(5, Color.Yellow);
            ColoredSquare square3 = new ColoredSquare(5, Color.Green);

            square1.PrintFigure();
            square2.PrintFigure();
            square3.PrintFigure();
        }
    }

    /* Добавьте свой код ниже */
    public struct ColoredSquare
    {
        private int length;
        private string[,] pic;
        private Color color;

        public ColoredSquare(int length, Color color)
        {
            this.length = length;
            this.color = color;
            pic = MakeFigurePic(length);
        }

        private static string[,] MakeFigurePic(int length)
        {
            string[,] outPic = new string[length, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || i == length - 1 || j == 0 || j == length - 1)
                    {
                        outPic[i, j] = "+ ";
                        continue;
                    }

                    outPic[i, j] = "  ";
                }
            }

            return outPic;
        }

        public void PrintFigure()
        {
            Console.ForegroundColor = (ConsoleColor)color;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(pic[i, j]);
                }

                Console.WriteLine();
            }
        }
    }

    public enum Color
    {
        Red = 12,
        Green = 10,
        Yellow =14
    }
}
