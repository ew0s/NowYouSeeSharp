using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t5
{
    public class Cat : Animal
    {
        public List<string> Moves;
        public Cat(string str, List<string> list)
        {
            Name = str;
            Moves = list;
        }
        public override void Play()
        {
            while (Moves.Count != 0)
            {
                Moves.Remove(Moves[Moves.Count - 1]);
                Thread.Sleep(500);
            }

            Program.winnerName = Name;

            Console.WriteLine($"У {Name} ходов больше нет!");
            Thread.CurrentThread.Abort();
        }
    }
}
