using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l8t28
{
    /*
     * Внутри файла Example.txt находятся простейшие математические примеры в формате: 
     *      "ЧислоА операция числоB"
     * Внутри класса Program создайте публичный статический асинхронный метод MakeTest(), который:
     *      1) Принимает целое число х, отвечающее за количество вопросов в тесте.
     *      2) Просит пользователя последовательно решить Х примеров, с формулировкой
     *         вопроса в формате: "А сколько будет: ХХХ ?", где ХХХ - случайный пример из файла.
     *      3) Анализирует считанный ответ пользователя с клавиатуры.
     *      4) По окончанию теста выводит в консоль результат теста в формате:
     *         "Примеров решено: ХХХ. Из них YYY было решено верно!", где ХХХ - общее
     *         число примеров, а YYY - количество правильно решенных ответов.
     * Внутри метода Main() последовательно выведите в консоль следующие фразы, каждую с новой строки:
     *      1) "Привет! Я шикарный самоучитель по математике!".
     *      2) "Сколько примеров будешь решать?".
     * После чего считайте с клавиатуры число и передайте его методу MakeTest() в качестве
     * аргумента при вызове.
     * При работе с файлом Example.txt используйте абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine("Привет! Я шикарный самоучитель по математике!");
            Console.WriteLine("Сколько примеров будешь решать?");
            int count = int.Parse(Console.ReadLine());

            MakeTest(count);
        }

        public static async void MakeTest(int x)
        {
            List<string> formulas;

            using (var fs = new FileStream(@"C:\Users\ew0s\Education\Course2\Lection8\l8t28\Example.txt", FileMode.Open))
            {
                using (TextReader textReader = new StreamReader(fs))
                {
                    formulas = (textReader.ReadToEnd()).Split('\n').ToList();
                }
            }

            WorkWithUser(x, formulas);
        }

        public static void WorkWithUser(int x, List<string> formulas)
        {
            int totalAnswers = 0;
            int rightAnswers = 0;
            var random = new Random();
            for (int i = 0; i < x; i++)
            {
                int index = random.Next(0, formulas.Count);
                string lValue = formulas[index].Split(' ', '\n')[0];
                string operation = formulas[index].Split(' ', '\n')[1];
                string rValue = formulas[index].Split(' ', '\r')[2];

                Console.WriteLine($"А сколько будет: {lValue} {operation} {rValue} ?");

                if (int.TryParse(Console.ReadLine(), out var value))
                {
                    if (IsCorrectAnswer(formulas[index], value)) rightAnswers++;
                    totalAnswers++;
                    continue;
                }

                totalAnswers++;
                formulas.Remove(formulas[index]);
            }

            Console.WriteLine($"Примеров решено: {totalAnswers}. Из них {rightAnswers} было решено верно!");
        }

        public static bool IsCorrectAnswer(string formula, int answer)
        {
            var lValue = int.Parse(formula.Split(' ')[0]);
            var operation = formula.Split(' ')[1];
            var rValue = int.Parse(formula.Split(' ')[2]);

            switch (operation)
            {
                case "+":
                    return lValue + rValue == answer;
                case "-":
                    return lValue - rValue == answer;
                case "*":
                    return lValue * rValue == answer;
                default:
                    return false;
            }
        }
    }
}
