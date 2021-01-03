using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t29
{
    /*
     * Внутри класс Program создайте статический метод GetClientList(), который:
     *      1) Принимает стек экземпляров класса DogClient и стек экземпляров класса CatClient.
     *      2) Возвращает типизированный стек, содержащий экземлпяры классов DogClient и CatClient расположенные через одного.
     *      3) Если стек экземпляров классов DogClient больше стека CatClient на 1 или равен ему, то верхним элементом
     *      возвращаемого стека должен являться экземпляр класса DogClient.
     *      4) Если стек экземпляров классов DogClient меньше стека CatClient на 1, то верхним элементом
     *      возвращаемого стека должен являться экземпляр класса CatClient.
     *      5) Если разница в количестве элементов стеков экземпляров класса DogClient и CatClient больше 2, то
     *      метод должен вернуть null.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Stack<CatClient> catClients = new Stack<CatClient>();
            catClients.Push(new CatClient());
            catClients.Push(new CatClient());
            catClients.Push(new CatClient());
            catClients.Push(new CatClient());

            Stack<DogClient> dogClients = new Stack<DogClient>();
            dogClients.Push(new DogClient());
            dogClients.Push(new DogClient());
            dogClients.Push(new DogClient());
            dogClients.Push(new DogClient());
            dogClients.Push(new DogClient());
            dogClients.Push(new DogClient());

            foreach (object o in GetClientList(dogClients, catClients))
            {
                Console.WriteLine(o);
            }
        }
        /* Добавьте свой код ниже */
        public static Stack<object> GetClientList(Stack<DogClient> dogClients, Stack<CatClient> catClients)
        {
            Stack<object> outStack = new Stack<object>();

            if (dogClients.Count - catClients.Count <= 1 && dogClients.Count - catClients.Count >= 0)
            {
                if (dogClients.Count == catClients.Count)
                {
                    while (dogClients.Count != 0 || catClients.Count != 0)
                    {
                        if (catClients.Count != 0)
                        {
                            outStack.Push(catClients.Pop());
                        }

                        if (dogClients.Count != 0)
                        {
                            outStack.Push(dogClients.Pop());
                        }
                    }
                }
                else
                {
                    while (dogClients.Count != 0 || catClients.Count != 0)
                    {
                        if (dogClients.Count != 0)
                        {
                            outStack.Push(dogClients.Pop());
                        }

                        if (catClients.Count != 0)
                        {
                            outStack.Push(catClients.Pop());
                        }
                    }
                }

                return outStack;
            }
            else if (catClients.Count - dogClients.Count == 1)
            {
                while (catClients.Count != 0 || dogClients.Count != 0)
                {
                    if (catClients.Count != 0)
                    {
                        outStack.Push(catClients.Pop());
                    }

                    if (dogClients.Count != 0)
                    {
                        outStack.Push(dogClients.Pop());
                    }
                }

                return outStack;
            }
            else
            {
                return null;
            }
        }
    }

    public class DogClient
    {
        public override string ToString()
        {
            return "Клиент собачка";
        }
    }

    public class CatClient
    {
        public override string ToString()
        {
            return "Клиент котик";
        }
    }
}
