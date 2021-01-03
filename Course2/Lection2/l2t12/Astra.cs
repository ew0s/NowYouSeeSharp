using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t12
{
    public class Astra : Auto
    {
        public Astra(string model, int maxSpeed, double weight) : base(model, maxSpeed, weight)
        {}

        public override string ToString()
        {
            return
                $"Автомобиль Астра, модель: {Model}, максимальная скорость: {MaxSpeed}, при этом весит всего-лишь: {Weight} тонны!";
        }
    }
}
