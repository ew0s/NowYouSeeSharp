﻿using System;

namespace l5t9
{
    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Can be drawn");
        }

        public void Move()
        {
            Console.WriteLine("Can be moved");
        }
    }

}
