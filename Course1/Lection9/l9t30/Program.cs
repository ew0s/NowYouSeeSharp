using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t30
{
    /*
     * Реализуем класс MyOwnStack, который будет обладать поведением стека. Для этого:
     *      1) Добавьте публичное свойство Count, которое будет отвечать за возвращение количества элементов в стеке, тип - целое число.
     *      2) Добавьте закрытое поле elements, которое будет отвечать за хранение всех элементов стека, тип - динамический массив.
     *      3) Добавьте метод Push(), который должен добавлять элемент в стек.
     *      4) Добавьте метод Pop(), который должен возвращать верхний элемент стека и удалять его из хранилища.
     *      5) Добавьте метод Peek(), который должен возвращать верхний элемент стека не удаляя его их хранилища.
     *      6) Добавьте метод ToList(), который должен возвращать все элементы стека в виде динамического массива.
     *      7) Добавьте метод SayHello(), который должен выводить в консоль фразу: "Привет, я твоя первая реализованная структура данных!".
     * Методы Pop() и Peek() должны возвращать -1, если внутреннее хранилище стека не содержит элементов.
     * Создайте публичное статическое поле stack для класса Program и присвойте ему новый экземпляр класса MyOwnStack.
     * Внутри метода Main() добавьте в stack числа от 1 до 10. Выведете на экран все элементы стека, каждый с новой строки.
     */

    public class Program
    {
        /* Добавьте свой код ниже */
        public static MyOwnStack stack = new MyOwnStack();
        
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 1; i <= 10; i++)
            {
                stack.Push(i);
            }

            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }

    public class MyOwnStack
    {
        /* Добавьте свой код ниже */
        public int Count
        {
            get
            {
                return elements.Count;
            }
        }
        private ArrayList elements;

        public MyOwnStack()
        {
            elements = new ArrayList();
        }

        public void Push(object element)
        {
            elements.Add(element);
        }

        public object Pop()
        {
            if (Count == 0)
            {
                return -1;
            }

            object output = elements[Count - 1];
            elements.Remove(elements[Count - 1]);
            return output;
        }

        public object Peek()
        {
            if (Count == 0)
            {
                return -1;
            }

            return elements[Count - 1];
        }

        public ArrayList ToList()
        {
            return elements;
        }

        public void SayHello()
        {
            Console.WriteLine("Привет, я твоя первая реализованная структура данных!");
        }
    }
}
