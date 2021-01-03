using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t26
{
    public class Cat
    {
        public int speed;
        public int age;
        public int weight;

        public Cat(int speed, int age, int weight)
        {
            this.speed = speed;
            this.age = age;
            this.weight = weight;
        }

        public static Cat operator +(Cat cat1, Cat cat2)
        {
            try
            {
                checked
                {
                    return new Cat(cat1.speed + cat2.speed, cat1.age + cat2.age, cat1.weight + cat2.weight);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Cat operator -(Cat cat1, Cat cat2)
        {
            try
            {
                checked
                {
                    return new Cat(Math.Abs(cat1.speed - cat2.speed), Math.Abs(cat1.age - cat2.age), Math.Abs(cat1.weight - cat2.weight));
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Cat operator *(Cat cat1, Cat cat2)
        {
            try
            {
                checked
                {
                    return new Cat(cat1.speed * cat2.speed, cat1.age * cat2.age, cat1.weight * cat2.weight);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Cat operator /(Cat cat1, Cat cat2)
        {
            return new Cat(default, default, default);
        }

        public override string ToString()
        {
            return $"Вес: {weight}, скорость: {speed}, возраст: {age}.";
        }
    }
}
