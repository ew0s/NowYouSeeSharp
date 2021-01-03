using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t13
{
    /*
     * Создайте класс MyStringFormatException являющийся исключением и создайте для него конструктор, который
     * принимает строку в качестве входящего параметра и устанавливает её значение свойству Message.
     * Внутри класса Program создайте публичный статический метод GetCustomString(), который:
     *      1) Принимает строку в качестве входящего параметра.
     *      2) Возвращает строку, регистр первого и последнего символа которого инвертирован.
     *      3) В случае если строка начинается или заканчивается символом, для которого понятие регистра
     *         не применимо, метод должен выбрасывать MyStringFormatException с указанием причины
     *         его вызова, в следующем формате:
     *         - "Строка начинается с символа ХХХ, для которого верхний или нижний регистр не применим."
     *         - "Строка заканчивается символом ХХХ, для которого верхний или нижний регистр не применим."
     *         - "Строка пустая или null."
     *         - "Строка вообще кривая... и начинается и заканчивается какой-то непонятной штукой..."
     * Логику формирования и выбора строки при выбрасывании исключения MyStringFormatException определите
     * самостоятельно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetCustomString("Hello"));
        }

        /* Добавьте свой код ниже */
        public static string GetCustomString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new MyStringFormatException("Строка пустая или null.");
            }

            var leftChar = input[0];
            var rightChar = input[input.Length - 1];

            if (!char.IsLetter(leftChar) && !char.IsLetter(rightChar))
            {
                throw new MyStringFormatException("Строка вообще кривая... и начинается и заканчивается какой-то непонятной штукой...");
            }

            if (!char.IsLetter(leftChar))
            {
                throw new MyStringFormatException($"Строка начинается с символа {leftChar}, для которого верхний или нижний регистр не применим.");
            }

            if (!char.IsLetter(rightChar))
            {
                throw new MyStringFormatException($"Строка заканчивается символом {rightChar}, для которого верхний или нижний регистр не применим.");
            }

            leftChar = char.IsLower(leftChar) ? char.ToUpper(leftChar) : char.ToLower(leftChar);
            rightChar = char.IsLower(rightChar) ? char.ToUpper(rightChar) : char.ToLower(rightChar);

            return leftChar + input.Substring(1, input.Length - 2) + rightChar;
        }
    }
}
