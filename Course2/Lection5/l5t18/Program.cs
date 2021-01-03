using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t18
{
    /*
     * Класс CatValidator получает по наследству реализацию метода, с некоторыми ограничениями.
     * Сейчас при возникновении этих ограничений метод выбрасывает исключение определенного типа.
     * В отдельном файле создайте новое исключение CatException.
     * Проанализируйте код, после чего создайте публичный метод Mult() в классе CatValidator, который:
     *      1) Будет отвечать за проверку полученного значения входящего параметра на пригодность
     *         его использования в методе Mult() родительского класса.
     *         1.1) Если значение подходящее - будет вызывать базовую реализацию метода Mult() и возвращать
     *              полученный результат.
     *         1.2) Если значение не подходит по условиям - будет выбрасывать новое исключение CatException.
     * Шаблон класса SimpleCat изменять нельзя. 
     */

    public class CatValidator : SimpleCat
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public new int Mult(int[][] arr)
        {
            try
            {
                return base.Mult(arr);
            }
            catch (Exception)
            {
                throw new CatException();
            }
        }
    }
}
