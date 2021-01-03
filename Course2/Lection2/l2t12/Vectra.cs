using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t12
{
    public class Vectra : Auto
    {
        public Vectra(string model, int maxSpeed, double weight) : base(model, maxSpeed, weight)
        {
        }

        public override string ToString()
        {
            return
                $"Автомобиль Vectra, модель: {Model}, максимальная скорость: {MaxSpeed}, а вес составляет: {Weight} тонны!";
        }
    }
}
