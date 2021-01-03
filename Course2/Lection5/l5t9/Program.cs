using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t9
{
    /*
     * Реализуйте метод PrintMainInfo() так, чтобы он вызывал метод Draw() у объекта типа Drawable и Move() у объекта типа Movable. 
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Object obj = new Circle();
            IMovable movable = (IMovable)obj;
            IDrawable drawable = new Rectangle();

            PrintMainInfo(drawable);
            PrintMainInfo(movable);
        }

        public static void PrintMainInfo(Object o)
        {
            switch (o)
            {
                case IDrawable iDrawable:
                    iDrawable.Draw();
                    break;
                case IMovable iMovable:
                    iMovable.Move();
                    break;
            }
        }
    }
}
